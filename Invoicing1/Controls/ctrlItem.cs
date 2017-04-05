using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Invoicing.Modul;

namespace Invoicing.Controls
{
  public partial class ctrlItem : _ctrlDefault
  {
    public int NrInvoice = 0;
    public List<int?> NrScan;
    public int InvoiceOrder = 0;

    public String Nazev { get; set; }
    public int ScanIncrement { get; set; }
    public int idInvoiceItem { get; set; }
    public double BasePrice { get; set; }
    public double Price { get; set; }
    public double PriceNoDPH { get; set; }
    public double BasePriceNoDPH { get; set; }
    public double Quantity { get; set; }
    public int idSazbaDPH
    {
      get { return (int)cmbDPH.SelectedValue; }
      set { cmbDPH.SelectedValue = value; }
    }
    public int idUnit
    {
      get { return (int)cmbUnit.SelectedValue; }
      set { cmbUnit.SelectedValue = value; }
    }

    public int Mode = 0; // Mode 1 znamená že děláme ADD, Mode 2 znamená, že děláme UPDATE.
    List<SazbaDPH> DPHAll;
    List<Unity> UnityAll;
    // Declare a delegate.
    public delegate void PriceChanged(object sender, int idItem);
    public delegate void ItemLeave(object sender, int idItem);
    public event PriceChanged PriceNoVatChanged;
    public event ItemLeave ctrlItemLeave;
    public delegate void ControlChanged(string sender, string Type, int InvoiceItem);   // informuji nadřízený proces, že stiskl  Button Up/Down
    public event ControlChanged myControlChanged;

    // ...


    public ctrlItem()
    {
      InitializeComponent();
      UnityAll = DB.GetUnities().FindAll(x => x.isEdit == true);
      DPHAll = DB.GetDPH();
      cmbUnit.DataSource = UnityAll;
      cmbUnit.DisplayMember = "UnitShort";
      cmbUnit.ValueMember = "idUnit";
      cmbUnit.SelectedIndex = 0;
      cmbDPH.DataSource = DPHAll;
      cmbDPH.DisplayMember = "SazbaDPHTextShort";
      cmbDPH.ValueMember = "idSazbaDPH";
      cmbDPH.SelectedIndex = 0;

    }

    private void ctrlAddItem_Load(object sender, EventArgs e)
    {

      if ((Mode & 1) == 1)    // NEW
      {

      }
      if ((Mode & 2) == 2)
      {// UPDATE
        txtNazev.Text = Nazev;
        txtCena.Text = Helper.DoubleToMoney(Price);
        txtPocet.Text = Quantity.ToString();
        txtJednotkovaCena.Text = Helper.DoubleToMoney(BasePrice);
        txtCenaBezDPH.Text = Helper.DoubleToMoney(PriceNoDPH);
      }
      lblNrInvoice.Text = NrInvoice.ToString();
      if (NrScan.Count() == 1)
      {
        txtScan.Text = NrScan[0].ToString();
        txtScan.Enabled = false;
      }
      else
      {
        txtScan.Enabled = true;
      }
      lblNrItem.Text = InvoiceOrder.ToString() + ".";

    }

    private void txtJednotkovaCena_Leave(object sender, EventArgs e)
    {
      try
      {
        BasePrice = float.Parse(txtJednotkovaCena.Text.Replace("Kč", ""));
        Price = BasePrice * Quantity;
        SazbaDPH AktDPH = DPHAll.Find(x => x.idSazbaDPH == (int)cmbDPH.SelectedValue);
        PriceNoDPH = Price * 100 / (100 + AktDPH.SazbaDPH1 ?? 0);
        BasePriceNoDPH = BasePrice * 100 / (100 + AktDPH.SazbaDPH1 ?? 0);
        if (txtCena.Text != String.Format("{0:0.00}", Price))
        {
          txtCena.Text = String.Format("{0:0.00}", Price);
          txtCenaBezDPH.Text = Helper.DoubleToMoney(PriceNoDPH);
        }
      }
      catch (Exception EX)
      {
        txtCena.Text = String.Format("{0:0.00}", 0);
      }
      finally { }
    }


    private void txtPocet_Leave(object sender, EventArgs e)
    {
      try
      {
        double dTemp;
        double.TryParse(txtPocet.Text, out dTemp);
        Quantity = dTemp;
        txtCena.Text = String.Format("{0:0.00}", BasePrice * Quantity);
        Price = BasePrice * Quantity;
        SazbaDPH AktDPH = DPHAll.Find(x => x.idSazbaDPH == (int)cmbDPH.SelectedValue);
        PriceNoDPH = Price * 100 / (100 + AktDPH.SazbaDPH1 ?? 0);
        BasePriceNoDPH = BasePrice * 100 / (100 + AktDPH.SazbaDPH1 ?? 0);
        txtCenaBezDPH.Text = Helper.DoubleToMoney(PriceNoDPH);
      }
      catch (Exception EX)
      {
        txtCena.Text = String.Format("{0:0.00}", 0);
      }
      finally { }
    }

    private void txtCena_Leave(object sender, EventArgs e)
    {
      try
      {
        Price = float.Parse(txtCena.Text.Replace("Kč", ""));
        SazbaDPH AktDPH = DPHAll.Find(x => x.idSazbaDPH == (int)cmbDPH.SelectedValue);
        PriceNoDPH = Price * 100 / (100 + AktDPH.SazbaDPH1 ?? 0);

        if (Quantity > 0)
        {
          BasePrice = Price / Quantity;
          BasePriceNoDPH = PriceNoDPH / Quantity;
        }
        else
        {
          BasePrice = 0;
          BasePriceNoDPH = 0;
        }
        txtCenaBezDPH.Text = Helper.DoubleToMoney(PriceNoDPH);
        if (txtJednotkovaCena.Text != String.Format("{0:0.00}", BasePrice))
        {
          txtJednotkovaCena.Text = String.Format("{0:0.00}", BasePrice);
          if (PriceNoVatChanged != null)
          {
            PriceNoVatChanged(this, InvoiceOrder);
          }
        }
      }
      catch (Exception EX)
      {
        txtJednotkovaCena.Text = String.Format("{0:0.00}", 0);
      }
      finally { }

    }

    private void ctrlItem_Leave(object sender, EventArgs e)
    {
      Nazev = txtNazev.Text;
      int ii;
      int.TryParse(txtScan.Text, out ii);
      ScanIncrement = ii;
      if (ctrlItemLeave != null)
      {
        ctrlItemLeave(this, InvoiceOrder);
      }

    }

    private void cmbDPH_Leave(object sender, EventArgs e)
    {
      txtCena_Leave(null, null);
    }

    private void cmbDPH_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtCena_Leave(null, null);
    }

    private void txtCenaBezDPH_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtNazev_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Down)
        myControlChanged("txtNazev", "DOWN", InvoiceOrder);
      if (e.KeyCode == Keys.Up)
        myControlChanged("txtNazev", "UP", InvoiceOrder);
    }
    private void txtJednotkovaCena_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Down)
        myControlChanged("txtJednotkovaCena", "DOWN", InvoiceOrder);
      if (e.KeyCode == Keys.Up)
        myControlChanged("txtJednotkovaCena", "UP", InvoiceOrder);

    }

    private void txtPocet_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Down)
        myControlChanged("txtPocet", "DOWN", InvoiceOrder);
      if (e.KeyCode == Keys.Up)
        myControlChanged("txtPocet", "UP", InvoiceOrder);

    }

    private void txtCena_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Down)
        myControlChanged("txtCena", "DOWN", InvoiceOrder);
      if (e.KeyCode == Keys.Up)
        myControlChanged("txtCena", "UP", InvoiceOrder);
    }

    public void SetMyFocus(string Nazev)
    {
      if (Nazev == "txtCena")
        txtCena.Select();
      else if (Nazev == "txtNazev")
        txtNazev.Select();
      else if (Nazev == "txtJednotkovaCena")
        txtJednotkovaCena.Select();
      else if (Nazev == "txtPocet")
        txtPocet.Select();
    }

   
 




  }
}
