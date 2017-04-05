using Invoicing.Modul;
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
  public partial class frmDetailOrder : _frmDefault
  {
    public frmDetailOrder()
    {
      InitializeComponent();
    }

    private void frmDetailOrder_Load(object sender, EventArgs e)
    {
      txtName.Text = ActiveOrder.OrderName;
      txtCreateDate.Text = (ActiveOrder.CreateDate ?? DateTime.Now).ToString("MM/dd/yyyy HH:mm:");
      txtScanPath.Text = ActiveOrder.SCANPath;
      txtNrSCAN.Text = ActiveOrder.NrSCAN.ToString();
      txtScanPrefix.Text = ActiveOrder.SCANPrefix;
      txtObdobi.Text = Helper.DateToMonthYear(ActiveOrder.OrderDate);
      txtZadavatel.Text = ActiveOrder.FirmName + " " + ActiveOrder.Adress + " " + ActiveOrder.ZipCode + " " + ActiveOrder.City + " IČ:" + ActiveOrder.Ic;
      lblId.Text = "Id:" + ActiveOrder.idOrder.ToString();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.Yes;
    }

    private void btnScanPDF_Click(object sender, EventArgs e)
    {
      List<String>Nenalezeno = new  List<String>();
      string myPath = Path.Combine( ActiveOrder.SCANPath,ActiveOrder.SCANPrefix);
      string FileName = myPath + "001.pdf";
      int iNalezeno = 0;
      if (!File.Exists(FileName)) {
        MessageBox.Show ("Nanalezen první soubor "+FileName+"\n Zkontrolujte cestu "+myPath);
        return;
      }
      for (int i = 0; i < ActiveOrder.NrSCAN; i++){
        FileName = myPath + (i+1).ToString("D3")+".pdf";
        if (File.Exists(FileName)){
          iNalezeno++;
        }else{
          Nenalezeno.Add(FileName);
        }
      }
      if (iNalezeno == ActiveOrder.NrSCAN){
         MessageBox.Show ("OK. Nalezeno "+iNalezeno.ToString() +" PDF souborů");
      }else{
        string sErr = "WARNING:  Nalezeno pouze "+iNalezeno.ToString()+" z celkových "  +ActiveOrder.NrSCAN.ToString() + " PDF souborů. Chybí ";
        foreach(string s in Nenalezeno){
          sErr += "\n" + s;
        }
        MessageBox.Show (sErr);
      }
    }
  }
}
