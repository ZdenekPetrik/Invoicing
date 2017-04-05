using Invoicing.Modul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Forms
{
  public partial class frmCommitPair : _frmDefault
  {
    public int idPairType = -1;
    public int idProduct = -1;
    public int idInvoiceItem = -1;

    private wProductTable wPT;
    private wPair wPr;
    private int AktWeek;

    public frmCommitPair()
    {
      InitializeComponent();
    }

    private void frmCommitPair_Load(object sender, EventArgs e)
    {
      if (!(idPairType > 0 && idProduct > 0 && idInvoiceItem > 0))
      {
        MessageBox.Show("Musí být vybrán zároveň Produkt a Položka z Faktury");
        this.Close();
        return;
      }
      wPT = DB.GetProductTable(idProduct);
      wPr = DB.GetPair(idInvoiceItem);
      AktWeek = wPr.InvoiceWeek ?? 0;
      GetProductInfo();
      GetItemInfo();
      GetNovyProdukt();
      tabControl1.SelectedIndex = idPairType - 1;

    }

    private void btnParuj_Click(object sender, EventArgs e)
    {
      if (tabControl1.SelectedIndex == 0)
      {
        if (DB.InsertPair(idInvoiceItem, idProduct, tabControl1.SelectedIndex + 1, (double)lblProduct1PriceCount.Tag, AktWeek))
          this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        else
          MessageBox.Show(DB.sErr);
      }
      else if (tabControl1.SelectedIndex == 3)
      {
        int idProduktNovy = idProduct;
        double DDCena = 0; double.TryParse(txtDDCena.Text.Replace("Kč", ""), out DDCena);
        if (DDCena <= 0)
        {
          MessageBox.Show("Cena musí být zadána");
          return;
        }
        if (chkCreateNewProduct.Checked)
        {
          double dQuantity = 0; double.TryParse(txtNovyProdukt_Mnozstvi.Text, out dQuantity);
          if (dQuantity <= 0)
          {
            MessageBox.Show("Množství musí být zadáno");
            return;
          }
          if (txtNovyProdukt_Nazev.Text.Length  < 4)
          {
            MessageBox.Show("Název produktu musí být alespoň 4 znaky");
            return;
          }
          idProduktNovy = DB.AddProduct(300, 300, 0, txtNovyProdukt_Nazev.Text, dQuantity, (int)cmbNovyProduktUnit.SelectedValue, "ALEXTRADE");
          if (idProduktNovy <= 0){
            MessageBox.Show(DB.sErr);
            return;
          }
        }

        DateTime DatePondeli = Helper.FromIso8601Weeknumber(AktWeek, (ActiveOrder.OrderDate ?? DateTime.Now).Year);
        DB.AddPrice(idProduktNovy, 5, DDCena, DatePondeli, AktWeek);
        if (DB.InsertPair(idInvoiceItem, idProduktNovy, tabControl1.SelectedIndex + 1, DDCena, AktWeek))
          this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        else
          MessageBox.Show(DB.sErr);
      }
      else if (tabControl1.SelectedIndex == 4)
      {
        if (DB.InsertPair(idInvoiceItem, -1, tabControl1.SelectedIndex + 1, 0, AktWeek))
          this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        else
          MessageBox.Show(DB.sErr);

      }

      else
      {
        MessageBox.Show("Ještě neumím");
        this.DialogResult = System.Windows.Forms.DialogResult.No;
      }
    }


    private void GetProductInfo()
    {
      lblProduct1Name.Text = wPT.Product;
      lblProduct1Druh.Text = wPT.Druh;
      lblProduct1Komodita.Text = wPT.Komodita;
      lblProduct1Podkomodita.Text = wPT.Podkomodita;
      lblProduct1Priznak.Text = wPT.Priznak;
      lblProduct1Mark.Text = wPT.Mark;
      lblProduct1Quantity.Text = wPT.Quantity.ToString();
      lblProduct1Unit.Text = wPT.UnitName;
      lblProduct1Week.Text = AktWeek.ToString();
      wWeekMinPricesTemp Min = DB.WeekMinPricesTemp(idProduct);
      if (Min == null)
      {
        lblProduct1Price.Text = "Nenalezeno";
        lblProduct1Price.Tag = .0;
        lblProduct1PriceCount.Text = "Nenalezeno";
        lblProduct1PriceCount.Tag = .0;
      }
      else
      {
        string sWeek = "C" + AktWeek.ToString();
        var Names = Min.GetType().GetProperty(sWeek);
        if (Names.GetValue(Min) == null){
          lblProduct1Price.Text = "0";
          lblProduct1Price.Tag = .0;
          lblProduct1PriceCount.Text = "0";
          lblProduct1PriceCount.Tag = .0;

      }else
        {
          double X = (double)(Names.GetValue(Min, null) ?? 0);
          lblProduct1Price.Text = Helper.DoubleToMoney(X) + " / kg";
          lblProduct1Price.Tag = X;
          lblProduct1PriceCount.Text = Helper.DoubleToMoney(X) + " / kg";
          lblProduct1PriceCount.Tag = X;
        }
      }
      cmbItemCountUnit.DataSource = DB.GetUnities().FindAll(x => x.isEdit == true && (x.UnitShort == "kg"  ||x.UnitShort == "g" || x.UnitShort == "l" || x.UnitShort == "ml" || x.UnitShort == "ml" ));
      cmbItemCountUnit.DisplayMember = "UnitShort";
      cmbItemCountUnit.ValueMember = "idUnit";
      cmbItemCountUnit.SelectedValue = 1;
    }

    private void GetItemInfo()
    {
      lblItemName.Text = wPr.ItemName;
      lblItemFirm.Text = wPr.FirmName;
      lblItemPrice.Text = Helper.DoubleToMoney(wPr.PriceBezDPH);
      lblItemBasePrice.Text = Helper.DoubleToMoney(wPr.BasePriceBezDPH) + " / " + wPr.UnitShort;
      lblItemQuantity.Text = wPr.Quantity.ToString();
      lblItemUnit.Text = wPr.UnitFull;
      if (wPr.idUnit == 3 || wPr.idUnit == 4)  // ks nebo karton
      {

      }
      else {
        txtItemCountQuantity.Text = wPr.Quantity.ToString();
        cmbItemCountUnit.SelectedValue = wPr.idUnit;
        lblItemCountPrice.Text = lblItemBasePrice.Text;
        txtItemCountQuantity.Enabled = false;
        cmbItemCountUnit.Enabled = false;
      }
    }

    private void GetNovyProdukt()
    {
      txtNovyProdukt_Nazev.Text = wPT.Product;
      txtNovyProdukt_Mnozstvi.Text = wPT.Quantity.ToString();
      cmbNovyProduktUnit.DataSource = DB.GetUnities().FindAll(x => x.isEdit == true);
      cmbNovyProduktUnit.DisplayMember = "UnitShort";
      cmbNovyProduktUnit.ValueMember = "idUnit";
      cmbNovyProduktUnit.SelectedValue = wPT.idUnit;
      lblNovyProduktWeek.Text = "Týden:  " + AktWeek.ToString();
    }

    private void txtItemCountQuantity_Leave(object sender, EventArgs e)
    {
      double Mnozstvi = 0;
      double.TryParse(txtItemCountQuantity.Text, out Mnozstvi);
      if (Mnozstvi > 0) {
        string Jednotka = "???";
        double Prepocet = 1;
        if (((int)cmbItemCountUnit.SelectedValue) == 1){   // kg
          Jednotka = "kg"; Prepocet = 1;
        }
        else if (((int)cmbItemCountUnit.SelectedValue) == 5) {  // g
          Jednotka = "kg"; Prepocet = 1000;
        }else if (((int)cmbItemCountUnit.SelectedValue) == 6) {  // mg
          Jednotka = "kg"; Prepocet = 1000000;
        }else if (((int)cmbItemCountUnit.SelectedValue) == 2){   // l
           Jednotka = "l"; Prepocet = 1;
        }else if (((int)cmbItemCountUnit.SelectedValue) == 7) {  // ml
           Jednotka = "l"; Prepocet = 1000;
        }
        lblItemCountPrice.Tag = (wPr.BasePriceBezDPH ?? 0) / (Mnozstvi/Prepocet);
        lblItemCountPrice.Text = Helper.DoubleToMoney((double)lblItemCountPrice.Tag)  + " / "+Jednotka ;

        lblProduct1PriceCount.Tag = (double) lblProduct1Price.Tag * (Mnozstvi/Prepocet);
        lblProduct1PriceCount.Text = Helper.DoubleToMoney((double)lblProduct1PriceCount.Tag)  + " / "+Jednotka ;        
      }
    }
  }
}
