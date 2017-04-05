using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicing.Modul;
using Invoicing.Controls;

namespace Invoicing.Forms
{
  public partial class frmAddItems : _frmDefault
  {
    public wInvoices Inv;
    private List<ScanPDFs> ScanPDFs;
    private List<ctrlItem> ctrlOneItem = new List<ctrlItem>();
    private List<wItems> dbItems;

    const int MINLENGTNAZEV = 4;

    public frmAddItems()
    {
      InitializeComponent();
    }

    private void frmAddItems_Load(object sender, EventArgs e)
    {

      dbItems = DB.GetItemsForInvoice(Inv.idInvoice);
      ScanPDFs = DB.GetScanPDFs(ActiveOrder.idOrder, Inv.idInvoice, -1);
      lblInvoice.Text = Inv.MyNumber + ".  " + Inv.FirmName + " " + Inv.FirmIc;
      txtNrItemsExpected.Text = Inv.NrItems.ToString();
      txtPriceExpected.Text = Helper.DoubleToMoney(Inv.Price);
      panel1.AutoScroll = false;
      panel1.HorizontalScroll.Enabled = false;
      panel1.HorizontalScroll.Visible = false;
      panel1.HorizontalScroll.Maximum = 0;
      panel1.AutoScroll = true;
      int LastPosition = 0;
      int PocetVyplnenych = 0;
      double PriceDone = 0;
      for (int i = 0; i < Inv.NrItems; i++)
      {
        wItems AktItem = dbItems.Find(x => x.InvoiceOrder == (i + 1));
        ctrlItem I = new ctrlItem();
        if (AktItem == null)
        {
          I.Mode = 1;
          I.NrScan = ScanPDFs.Select(x => x.ScanIncrement).ToList<int?>();
          I.InvoiceOrder = i + 1;
          I.NrInvoice = Inv.MyNumber??0;
          I.Nazev = "";
          I.idUnit = 1;
          I.idSazbaDPH = 1;
          I.idInvoiceItem = -1;
          I.BasePriceNoDPH = 0;
          I.PriceNoDPH = 0;
        }
        else
        {
          I.Mode = 2;
          I.ScanIncrement = AktItem.ScanIncrement ?? 0;
          I.NrScan = ScanPDFs.Select(x => x.ScanIncrement).ToList<int?>();
          I.InvoiceOrder = AktItem.InvoiceOrder ?? 0;
          I.Nazev = AktItem.ItemName;
          I.idUnit = AktItem.idUnit ?? 0;
          I.idSazbaDPH = AktItem.idSazbaDPH ?? 0;
          I.idInvoiceItem = AktItem.idInvoiceItem;
          I.BasePrice = AktItem.BasePrice ?? 0;
          I.Price = AktItem.Price ?? 0;
          I.Quantity = AktItem.Quantity ?? 0;
          I.BasePriceNoDPH = AktItem.BasePriceBezDPH ?? 0;
          I.PriceNoDPH = AktItem.PriceBezDPH ?? 0;
          PriceDone += I.PriceNoDPH;
          PocetVyplnenych++;
        }
        I.ctrlItemLeave += I_ctrlItemLeave;
        I.PriceNoVatChanged += PriceNoVatChanged;
        I.Top = 20 + (I.Height + 2) * i;
        I.myControlChanged += I_myControlChanged;
        panel1.Controls.Add(I);
        LastPosition = 20 + ((I.Height + 2) * i) + I.Height;
        ctrlOneItem.Add(I);
      }
      panel1.Height = (LastPosition + 30) > 400 ? 400 : (LastPosition + 30);
      this.Height = 60 + panel1.Top + panel1.Height + 40;
      txtNrItemsDone.Text = PocetVyplnenych.ToString();
      txtPriceDone.Text = Helper.DoubleToMoney(PriceDone);
      btnSave.Top = this.ClientSize.Height - 40;
    }

    void I_myControlChanged(string sender, string Type, int InvoiceItem)
    {
      if ((Type == "UP" && InvoiceItem > 1) || (Type == "DOWN" && InvoiceItem < Inv.NrItems)){
        if (Type == "UP")
          ctrlOneItem[(InvoiceItem-2)].SetMyFocus(sender);
        if (Type == "DOWN")
          ctrlOneItem[(InvoiceItem)].SetMyFocus(sender);
      
      }
    }



    private void btnSave_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Opravdu uložit???", "Ukládání Položek", MessageBoxButtons.YesNo))
        return;
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < ctrlOneItem.Count; i++)
      {
        ctrlItem AktItem = ctrlOneItem[i];
        if (AktItem.Mode == 1)
        {
          if (AktItem.Nazev.Length < MINLENGTNAZEV && (AktItem.BasePrice > 0 || AktItem.Price > 0))
            sb.Append((AktItem.InvoiceOrder).ToString() + ". položka => Není vyplněn název\r\n");
          if (AktItem.BasePrice == 0 && (AktItem.Nazev.Length > MINLENGTNAZEV || AktItem.Price > 0))
            sb.Append(AktItem.InvoiceOrder.ToString() + ". položka => Není vyplněna jednotková cena\r\n");
          if (AktItem.Price == 0 && (AktItem.Nazev.Length > MINLENGTNAZEV || AktItem.BasePrice > 0))
            sb.Append(AktItem.InvoiceOrder.ToString() + ". položka => Není vyplněna celková cena\r\n");
        }
      }
      string Err = sb.ToString();
      if (Err.Length > 0)
      {
        MessageBox.Show(Err);
        return;
      }

      for (int i = 0; i < ctrlOneItem.Count; i++)
      {
        ctrlItem AktItem = ctrlOneItem[i];
        InvoiceItems I2 = new InvoiceItems();

        I2.BasePrice = AktItem.BasePrice;
        I2.idInvoice = Inv.idInvoice;
        I2.idInvoiceItem = AktItem.idInvoiceItem;
        I2.idUnit = AktItem.idUnit;
        I2.idSazbaDPH = AktItem.idSazbaDPH;
        I2.ItemName = AktItem.Nazev;
        I2.Price = AktItem.Price;
        I2.Quantity = AktItem.Quantity;
        I2.ScanIncrement = AktItem.ScanIncrement;
        I2.InvoiceOrder = AktItem.InvoiceOrder;
        I2.PriceBezDPH = AktItem.PriceNoDPH;
        I2.BasePriceBezDPH = AktItem.BasePriceNoDPH;

        if (AktItem.Mode == 1 && I2.idInvoiceItem == -1 && AktItem.Nazev.Length >= MINLENGTNAZEV && AktItem.BasePrice > 0 && AktItem.Price > 0)
          DB.InvoiceItemAddOrUpdate(I2, AktItem.Mode);
        else if (AktItem.Mode == 2 && I2.idInvoiceItem > 0 && AktItem.Nazev.Length >= MINLENGTNAZEV && AktItem.BasePrice > 0 && AktItem.Price > 0)
          DB.InvoiceItemAddOrUpdate(I2, AktItem.Mode);
        else if (AktItem.Mode == 2 && I2.idInvoiceItem > 0 && AktItem.Nazev.Length < MINLENGTNAZEV && AktItem.BasePrice == 0 && AktItem.Price == 0)
          DB.InvoiceItemDelete(AktItem.idInvoiceItem);
        else if (AktItem.Mode == 1 && I2.idInvoiceItem == -1 && AktItem.Nazev.Length < MINLENGTNAZEV && AktItem.BasePrice == 0 && AktItem.Price == 0)
        {
          // Prazdny novy radek - no tak ho nech
        }
        else
          MessageBox.Show("Nevím co dělat s Item " + i.ToString());
      }
      if (ActiveOrder.MaxStateValue <= (int)CDatabase.eOrderState.F2_Caption)
      {
        if (txtNrItemsDone.Text == txtNrItemsExpected.Text && (txtPriceDone.Text == txtPriceExpected.Text))
        {
          if (Inv.StateValue == null || (Inv.StateValue == (int)CDatabase.eInvoiceState.I1_New))
            DB.InvoiceStateNew(Inv.idInvoice, (int)CDatabase.eInvoiceState.I2_Items);
        }
        else
        {
          if (Inv.StateValue == (int)CDatabase.eInvoiceState.I2_Items)
            DB.InvoiceStateNew(Inv.idInvoice, (int)CDatabase.eInvoiceState.I1_New);
        }
      }
      this.DialogResult = System.Windows.Forms.DialogResult.Yes;
    }
    void PriceNoVatChanged(object sender, int e)
    {
      double f = 0;
      foreach (ctrlItem I in ctrlOneItem)
      {
        f += I.PriceNoDPH;
      }
      txtPriceDone.Text = Helper.DoubleToMoney(f);
    }
    void I_ctrlItemLeave(object sender, int idItem)
    {
      int PocetVyplnenych = 0;
      foreach (ctrlItem I in ctrlOneItem)
      {
        if (I.Price > 0 && (I.Nazev.Length > 2))
          PocetVyplnenych++;
      }
      txtNrItemsDone.Text = PocetVyplnenych.ToString();
      PriceNoVatChanged(null, idItem);
    }

    private void txtNrItemsDone_TextChanged(object sender, EventArgs e)
    {
      if (txtNrItemsDone.Text == txtNrItemsExpected.Text)
        txtNrItemsDone.BackColor = System.Drawing.Color.LightGreen;
      else
        txtNrItemsDone.BackColor = System.Drawing.Color.White;
    }

    private void txtPriceDone_TextChanged(object sender, EventArgs e)
    {

      if (txtPriceDone.Text == txtPriceExpected.Text)
        txtPriceDone.BackColor = System.Drawing.Color.LightGreen;
      else
        txtPriceDone.BackColor = System.Drawing.Color.White;

    }


  }
}
