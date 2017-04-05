using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Forms
{
  public partial class frmAddOrder : _frmDefault
  {
    int ActiveZadavatel = -1;
    string OrderPath1;
    string OrderPath2;

    public frmAddOrder()
    {
      InitializeComponent();
    }

    private void frmDetailOrder_Load(object sender, EventArgs e)
    {
      OrderPath1 = DB.GetSettingS("OrderPath1");
      OrderPath2 = DB.GetSettingS("OrderPath2");
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (ActiveZadavatel <= 0)
      {
        MessageBox.Show("Pole Zadavatel musí být vyplněno. Jedná se o firmu, na kterou jsou směrovány všechny faktury");
        return;
      }
      if (txtPrefixFilePDF.Text.Length < 1)
      {
        MessageBox.Show("Pole Prefix musí být vyplněno. Jedná se o název souborů PDF, který se nemění (neboli vše před ...001.pdf)");
        return;
      }
      if (dtOrderSeason.Value.Month == DateTime.Now.Month && dtOrderSeason.Value.Year == DateTime.Now.Year)
      {
        MessageBox.Show("Vyplňte pole Období. Jedná se o měsíc v kterém jsou faktury sledovány. ");
        return;
      }
      if (txtName.Text.Length < 1)
      {
        MessageBox.Show("Pole Název zakázky musí být vyplněno. ");
        return;
      }

      int nrScan;
      int.TryParse(txtNrSCAN.Text,out nrScan);
      if (DB.NewOrder(ActiveZadavatel, txtName.Text, dtOrderSeason.Value, txtScanPath.Text, txtPrefixFilePDF.Text, nrScan))
        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
      else
        MessageBox.Show(DB.sErr);
    }

    private void btnScanPDF_Click(object sender, EventArgs e)
    {
      List<String>Nenalezeno = new  List<String>();
      string myPath = Path.Combine(txtScanPath.Text, txtPrefixFilePDF.Text);
      string FileName = myPath + "001.pdf";
      int iNalezeno = 0;
      if (!File.Exists(FileName)) {
        MessageBox.Show ("Nanalezen první soubor "+FileName+"\n Zkontrolujte cestu "+myPath);
        return;
      }
      int iNrScan = 1;
      int.TryParse(txtNrSCAN.Text, out iNrScan);
      for (int i = 0; i < iNrScan; i++)
      {
        FileName = myPath + (i+1).ToString("D3")+".pdf";
        if (File.Exists(FileName)){
          iNalezeno++;
        }else{
          Nenalezeno.Add(FileName);
        }
      }
      if (iNalezeno == iNrScan)
      {
         MessageBox.Show ("OK. Nalezeno "+iNalezeno.ToString() +" PDF souborů");
      }else{
        string sErr = "WARNING:  Nalezeno pouze "+iNalezeno.ToString()+" z celkových "  +ActiveOrder.NrSCAN.ToString() + " PDF souborů. Chybí ";
        foreach(string s in Nenalezeno){
          sErr += "\n" + s;
        }
        MessageBox.Show (sErr);
      }
    }

    private void btnZadavatel_Click(object sender, EventArgs e)
    {
      frmDodavatele D = new frmDodavatele();
      if (System.Windows.Forms.DialogResult.Yes == D.ShowDialog(this))
        ZobrazFirmu(D.idDodavatel);
    }

    private void ZobrazFirmu(int idDodavatel)
    {
      wFirms F = DB.GetFirm(idDodavatel);
      txtZadavatel.Text = F.Name + " Ič: " + F.Ic + " Dič: " + F.Dic + " Ads: " + F.Adress + " " + F.ZipCode + " " + F.City;
      ActiveZadavatel = F.idFirm;
    }

    private void btnDirectoryPDF_Click(object sender, EventArgs e)
    {
      using (var fbd = new FolderBrowserDialog())
      {
        DialogResult result = fbd.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
          string[] files = Directory.GetFiles(fbd.SelectedPath);
          txtScanPath.Text = fbd.SelectedPath.Replace(OrderPath1, OrderPath2);
          txtNrSCAN.Text = files.Count().ToString();
        }
      }
    }

  }
}
