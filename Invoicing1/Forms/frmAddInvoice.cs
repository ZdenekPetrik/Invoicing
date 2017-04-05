using Invoicing.Modul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Forms
{
  public partial class frmAddInvoice : _frmDefault
  {
    private int idFirmActive = -1;

    public wInvoices Inv;
    private int PoradiDD; 

    public int Mode = 1;      // 1 New, 2=Edit, 3 Smaž 
    public frmAddInvoice()
    {
      InitializeComponent();
    }

    
    private void btnDodavatelAdd_Click(object sender, EventArgs e)
    {
      frmDodavatele D = new frmDodavatele();
      if (System.Windows.Forms.DialogResult.Yes == D.ShowDialog(this))
        ZobrazFirmu(D.idDodavatel);
    }

    private void ZobrazFirmu(int idDodavatel)
    {
      wFirms F = DB.GetFirm(idDodavatel);
      txtFirmInfo.Text = F.Name + " Ič: " + F.Ic + " Dič: " + F.Dic + " Ads: " + F.Adress + " " + F.ZipCode + " " + F.City;
      idFirmActive = F.idFirm;
    }

    private void frmAddInvoice_Load(object sender, EventArgs e)
    {
      btnDelete.Visible = btnSave.Visible = btnEdit.Visible = false;
      if (Mode == 1) { 
        this.Text = "Faktura  (Dodací list)  ADD";
        PoradiDD = DB.GetInvoices(ActiveOrder.idOrder).Count()+1;
        btnSave.Visible = true;
      }
      if (Mode == 2) { 
        this.Text = "Faktura  (Dodací list)  EDIT";
        PoradiDD = Inv.MyNumber??0;
        btnEdit.Visible = true;
        ShowPolozky();
      }
      if (Mode == 3) {
        PoradiDD = Inv.MyNumber??0;
        btnDelete.Visible = true;
        this.Text = "Faktura  (Dodací list)  DELETE";
        ShowPolozky();
      }
      if (Mode == 4)
      {
        this.Text = "Faktura  (Dodací list)  DETAIL";
        ShowPolozky();
      }
      InitAutocomplete();
    }



    private void InitAutocomplete()
    {
      List<wFirms> FirmList = DB.GetFirms();
      cmbAutocompleteFirm.DisplayMember = "Ico";
      cmbAutocompleteFirm.DroppedDown = true;

      List<string> list = new List<string>();
      foreach (wFirms row in FirmList)
      {
        list.Add(row.Ic);
      }
      this.cmbAutocompleteFirm.Items.AddRange(list.ToArray<string>());
      cmbAutocompleteFirm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      cmbAutocompleteFirm.AutoCompleteSource = AutoCompleteSource.ListItems;
    }
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern short GetKeyState(Keys key);
    private void cmbAutocompleteFirm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter && GetKeyState(Keys.Enter) < 0)
      {
        wFirms F =  DB.GetFirms(cmbAutocompleteFirm.Text,"").FirstOrDefault();
        if (F.Ic.Length > 0)
          ZobrazFirmu(F.idFirm);
      }
    }
 
  
    private void ShowPolozky()
    {
      ZobrazFirmu(Inv.idFirm??0);
      lblPoradiDD.Text = Inv.MyNumber.ToString()+".";
      txtHisNumber.Text = Inv.HisNumber;
      txtPriceFull.Text = Helper.DoubleToMoney(Inv.Price);
      txtPDFScan.Text = Inv.ScanPDFsAll;
      txtNrItems.Text = Inv.NrItems.ToString();
      dtDUZP.Value = Inv.DateDUZP ?? DateTime.Now;
    }



    private void btnSave_Click(object sender, EventArgs e)
    {
      List<int> listScan = GetListScan();
      if (listScan.Count == 0)
        return;
      double dPrice = -1;
      double.TryParse(txtPriceFull.Text, out dPrice);
      if (dPrice == 0 || dPrice == -1)
      {
        MessageBox.Show("Zadejte cenu faktury");
        return;
      }
      int NrItems = -1;
      int.TryParse(txtNrItems.Text, out NrItems);
      if (NrItems == 0 || NrItems == -1)
      {
        MessageBox.Show("Zadejte Počet položek");
        return;
      }

      foreach (int i in listScan)
      {
        List<ScanPDFs> S = DB.GetScanPDFs(ActiveOrder.idOrder, -1, i);
        if (S != null && S.Count > 0)
        {
          MessageBox.Show(String.Format("PDF {0} je již zaregistrováno na faktuře id:{1}", i, S[0].idInvoice));
          return;
        }

      }
      int NewIdInvoice = DB.NewInvoice(PoradiDD, txtHisNumber.Text, NrItems, dPrice, dtDUZP.Value, idFirmActive, ActiveOrder.idOrder);
      if (NewIdInvoice > 0)
      {
        foreach (int i in listScan)
        {
          if (!DB.NewScanPDFs(ActiveOrder.idOrder, NewIdInvoice, i))
          {
            MessageBox.Show(DB.sErr);
            return;
          }
        }
      }
      else
      {
        MessageBox.Show(DB.sErr);
        return;
      }
      txtHisNumber.Text = "";
      txtPriceFull.Text = "";
      txtPDFScan.Text = (listScan[listScan.Count - 1] + 1).ToString("D3");
      txtNrItems.Text = "";
    }

    private List<int> GetListScan()
    {
      List<int> listScan = new List<int>();
      if (txtPDFScan.Text.Length == 0)
      {
        MessageBox.Show("Zadejte ScanPDF ve tvaru 2 nebo 2,3,4 nebo 002,003,004");
        return listScan;
      }
      if (!CheckNumbers(txtPDFScan.Text))
      {
        MessageBox.Show("Zadejte ScanPDF může obsahovat pouze číslice a čárky");
        return listScan;
      }
      String[] Scan = txtPDFScan.Text.Split(',');
      foreach (string s in Scan)
      {
        int iScan;
        int.TryParse(s, out iScan);
        //        List<String> Nenalezeno = new List<String>();
        listScan.Add(iScan);
        string myPath = Path.Combine(ActiveOrder.SCANPath, ActiveOrder.SCANPrefix);
        string FileName = myPath + (iScan).ToString("D3") + ".pdf";
        if (!File.Exists(FileName))
        {
          MessageBox.Show("Nanalezen soubor " + FileName + "\n Zkontrolujte cestu " + myPath);
          return new List<int>();
        }
      }
      return listScan;
    }

    private bool CheckNumbers(string sNumbers)
    {
      for (int i = 0; i < sNumbers.Length; i++)
      {
        char ch = sNumbers[i];
        if ((ch >= '0' && ch <= '9') || ch == ',')
        { }
        else
        {
          return false;
        }
      }
      return true;
    }

    private void btnShoPDF_Click(object sender, EventArgs e)
    {
      List<int> listScan = GetListScan();
      if (listScan.Count == 0)
        return;
      string myPath = Path.Combine(ActiveOrder.SCANPath, ActiveOrder.SCANPrefix);
      foreach (int i in listScan)
      {      
        string FileName = myPath + (i).ToString("D3") + ".pdf";
        if (!File.Exists(FileName))
        {
          MessageBox.Show("Nanalezen první soubor " + FileName + "\n Zkontrolujte cestu " + myPath);
        }else{
          System.Diagnostics.Process.Start(FileName);
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes == MessageBox.Show("Opravdu smazat tuto Fakturu?", "", MessageBoxButtons.YesNo)) {
        if (DB.InvoiceDelete(Inv.idInvoice))
          this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        else
          MessageBox.Show (DB.sErr);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      bool isChange = false;
      if (idFirmActive != -1 && idFirmActive != Inv.idFirm) { 
        Inv.idFirm = idFirmActive;
        isChange = true;
      }
      if (Inv.HisNumber != txtHisNumber.Text)
      {
        Inv.HisNumber = txtHisNumber.Text;
        isChange = true;
      }
      float f = 0;
      float.TryParse(txtPriceFull.Text.Replace("Kč",""), out f);
      if (f != Inv.Price)
      {
        Inv.Price = f;
        isChange = true;
      }
      if (Inv.ScanPDFsAll != txtPDFScan.Text)
      {
        Inv.ScanPDFsAll = txtPDFScan.Text;
        isChange = true;
      }
      int i = 0;
      int.TryParse(txtNrItems.Text, out i);
      if (i != Inv.NrItems) {
        Inv.NrItems = i;
        isChange = true;
      }
      if (dtDUZP.Value != (Inv.DateDUZP ?? DateTime.Now)){
        Inv.DateDUZP = dtDUZP.Value ;
        isChange = true;      
      }
      if (isChange)
        DB.InvoiceUpdate(Inv);
      this.DialogResult = System.Windows.Forms.DialogResult.Yes;
    }

 
  }
}
