using Invoicing.Controls;
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
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    ctrlShowOrder ctrlShowOrder1;
    ctrlInvoicesList ctrlInvoices1;
    ctrlSuppliers ctrlSuppliers1;
    ctrlScanPDFs ctrlScanPDFs1;

    CInvoices Inv;



    private void frmMain_Load(object sender, EventArgs e)
    {
      statusStrip1.Text = "Verze " + Application.ProductVersion.ToString();
      Program.LoginUser = new CUser();
      Program.LoginUser.getUser(Environment.UserName, "");
      if (Program.LoginUser.isLogin == false || Program.LoginUser.isInvoicing == false)
      {
        MessageBox.Show(Environment.UserName + " --- Nemáte práva");
        Environment.Exit(0);
      }
      Program.DB = new CDatabase(Program.LoginUser.idUser, "Invoicing");
      string sActiveOrder = Program.DB.GetUserParameter("ActiveOrder");
      if (sActiveOrder.Length == 0)
      {
        Program.idActiveOrder = -1;
      }
      else
      {
        int.TryParse(sActiveOrder, out Program.idActiveOrder);
      }
      if (Program.idActiveOrder != -1)
        Program.ActiveOrder = Program.DB.GetOrder(Program.idActiveOrder);

      Inv = new CInvoices();
      CreatePanels();
      FormResize();
      SplitContainerResize();
      tabControlsUp_Resize(null, null);
      InvoiceItemsRefresh(0);
    }
    #region Menu
    private void Menu_OrderChange_Click(object sender, EventArgs e)
    {
      frmFindOrder frm = new frmFindOrder();
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        Program.DB.SetUserParameter("ActiveOrder", Program.idActiveOrder.ToString());
        Program.ActiveOrder = Program.DB.GetOrder(Program.idActiveOrder);
        RefreshPanels();
      }
    }
    private void Menu_OrderDetail_Click(object sender, EventArgs e)
    {
      frmDetailOrder frm = new frmDetailOrder();
      frm.ShowDialog();

    }
    private void Menu_OrderNew_Click(object sender, EventArgs e)
    {
      frmAddOrder frm = new frmAddOrder();
      frm.ShowDialog();
    }

    private void menuHorniAdd_Click(object sender, EventArgs e)
    {
      frmAddInvoice FrmAdd = new frmAddInvoice();
      FrmAdd.ShowDialog();
    }

    private void menuHorniDetail_Click(object sender, EventArgs e)
    {
      if (tabControlsUp.SelectedIndex == 0)
        EditOneInvoiceForm(false);
      if (tabControlsUp.SelectedIndex == 1)
        DeleteOneFirmForm();
      if (tabControlsUp.SelectedIndex == 2)
        MessageBox.Show("No Able");
    }


    private void menuHorniRefresh_Click(object sender, EventArgs e)
    {
      RefreshPanels();
    }

    private void menu_ItemsNew_Click(object sender, EventArgs e)
    {
      if (tabControlsUp.SelectedIndex == 0)
        ShowForItemsNew(ctrlInvoices1.GetActiveInvoice());
      if (tabControlsUp.SelectedIndex == 1)
        MessageBox.Show("No Able");
      if (tabControlsUp.SelectedIndex == 2)
        MessageBox.Show("No Able");

    }
    private void menuHorniEdit_Click(object sender, EventArgs e)
    {
      EditOneInvoiceForm(true);
    }
    private void menuHorniDelete_Click(object sender, EventArgs e)
    {
      if (tabControlsUp.SelectedIndex == 0)
        DeleteOneInvoiceForm();
      if (tabControlsUp.SelectedIndex == 1)
        DeleteOneFirmForm();
      if (tabControlsUp.SelectedIndex == 2)
        MessageBox.Show("No Able");
    }

    private void DeleteOneInvoiceForm()
    {
      frmAddInvoice frm = new frmAddInvoice();
      frm.Mode = 3;
      frm.Inv = ctrlInvoices1.GetActiveInvoice();
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        RefreshPanels();
      }
    }
    private void EditOneInvoiceForm(bool isEdit)
    {
      frmAddInvoice frm = new frmAddInvoice();
      frm.Mode = isEdit ? 2 : 4;
      frm.Inv = ctrlInvoices1.GetActiveInvoice();
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        RefreshPanels();
      }
    }
    private void DeleteOneFirmForm()
    {
      MessageBox.Show("No Able now - will be soon");

    }

    private void menu_Refresh_Click(object sender, EventArgs e)
    {
      RefreshPanels();
    }

    private void menu_ParovaniCen_Click(object sender, EventArgs e)
    {
      FrmPair f = new FrmPair();
      f.Show();
    }




    #endregion




    private void ShowForItemsNew(wInvoices Inv)
    {
      frmAddItems frmAI = new frmAddItems();
      frmAI.Inv = Inv;
      frmAI.ShowDialog();
      RefreshPanels();
    }

    private void CreatePanels()
    {
      ctrlShowOrder1 = new ctrlShowOrder();
      panelOrder.Controls.Add(ctrlShowOrder1);
      ctrlInvoices1 = new ctrlInvoicesList();
      tabControlsUp.TabPages[0].Controls.Add(ctrlInvoices1);
      ctrlSuppliers1 = new ctrlSuppliers();
      tabControlsUp.TabPages[1].Controls.Add(ctrlSuppliers1);
      ctrlScanPDFs1 = new ctrlScanPDFs();
      tabControlsUp.TabPages[2].Controls.Add(ctrlScanPDFs1);
      //      ctrlInvoicesList1.myContexMenuClicked += ctrlInvoicesList1_myContexMenuClicked;
      ctrlInvoices1.myControlChanged += ctrlInvoicesList1_myControlChanged;
      ctrlSuppliers1.myControlChanged += ctrlSuppliers1_myControlChanged;
      ctrlScanPDFs1.myControlChanged += ctrlScanPDFs1_myControlChanged;
    }



    private void RefreshPanels()
    {
      ctrlShowOrder1.RefreshPanel();
      ctrlShowOrder1.RefreshData();
      ctrlSuppliers1.RefreshPanel();
      ctrlSuppliers1.RefreshData();
      ctrlInvoices1.RefreshData();
      ctrlInvoices1.RefreshPanel();
      ctrlScanPDFs1.RefreshPanel();
      ctrlScanPDFs1.RefreshData();
    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
      FormResize();
    }

    private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
    {
      SplitContainerResize();
    }

    private void tabControlsUp_Resize(object sender, EventArgs e)
    {
      if (tabControlsUp.TabPages[0].Controls.Count > 0)
        tabControlsUp.TabPages[0].Controls[0].Size = new Size(splitContainer1.Panel1.ClientRectangle.Width - 2, splitContainer1.Panel1.Height - 2);
      if (tabControlsUp.TabPages[1].Controls.Count > 0)
        tabControlsUp.TabPages[1].Controls[0].Size = new Size(splitContainer1.Panel1.ClientRectangle.Width - 2, splitContainer1.Panel1.Height - 2);
      if (tabControlsUp.TabPages[2].Controls.Count > 0)
        tabControlsUp.TabPages[2].Controls[0].Size = new Size(splitContainer1.Panel1.ClientRectangle.Width - 2, splitContainer1.Panel1.Height - 2);
    }

    private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
    {
      SplitContainerResize();
    }


    private void SplitContainerResize()
    {
      tabControlsUp.Top = 1;
      tabControlsUp.Left = 1;
      tabControlsUp.Width = splitContainer1.Panel1.ClientSize.Width - 2;
      tabControlsUp.Height = splitContainer1.Panel1.ClientSize.Height - 2;
      ctrlListItems1.Top = 0;
      ctrlListItems1.Left = 0;
      ctrlListItems1.Width = splitContainer1.Panel2.ClientSize.Width - 2;
      ctrlListItems1.Height = splitContainer1.Panel2.ClientSize.Height - 2;

    }

    private void FormResize()
    {
      splitContainer1.Top = 70;
      splitContainer1.Left = 1;
      splitContainer1.Width = this.ClientRectangle.Width - 5;
      splitContainer1.Height = this.ClientRectangle.Height - (splitContainer1.Top + 20);
    }

    private void fáze01FakturyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFaseChange frm = new frmFaseChange();
      frm.Fase = 1;
      frm.Show();
    }

    private void fáze12PoložkyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFaseChange frm = new frmFaseChange();
      frm.Fase = 2;
      frm.Show();
    }

    private void fáze23PárováníPoložekToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFaseChange frm = new frmFaseChange();
      frm.Fase = 3;
      frm.Show();
    }

    private void fáze34ReportingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFaseChange frm = new frmFaseChange();
      frm.Fase = 4;
      frm.Show();
    }

    private void fáze45CloseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFaseChange frm = new frmFaseChange();
      frm.Fase = 5;
      frm.Show();
    }




    private void InvoiceItemsRefresh(int Row)
    {
      int idInvoice = ctrlInvoices1.GetActiveIdInvoiceOnRow(Row);
      if (idInvoice >= 0)
      {
        ctrlListItems1.TypeParent = 1;
        ctrlListItems1.dbItems = Program.DB.GetItemsForInvoice(idInvoice);
        ctrlListItems1.RefreshData();
      }
    }
    private void SupplierItemsRefresh(int Row)
    {
      int idFirm = ctrlSuppliers1.GetActiveIdFirmOnRow(Row);
      if (idFirm >= 0)
      {
        ctrlListItems1.TypeParent = 2;
        ctrlListItems1.dbItems = Program.DB.GetItemsForFirm(Program.ActiveOrder.idOrder, idFirm);
        ctrlListItems1.RefreshData();
      }
    }
    private void ScanPDFItemsRefresh(int Row)
    {
      int idScan = ctrlScanPDFs1.GetActiveIdScanOnRow(Row);
      if (idScan >= 0)
      {
        ctrlListItems1.TypeParent = 4;
        ctrlListItems1.dbItems = Program.DB.GetItemsForPDF(idScan);
        ctrlListItems1.RefreshData();
      }
    }




    private void tabControlsUp_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControlsUp.SelectedIndex == 0)
      {
        int idInvoice = ctrlInvoices1.GetActiveIdInvoice();
        if (idInvoice > 0)
        {
          ctrlListItems1.TypeParent = 1;
          ctrlListItems1.dbItems = Program.DB.GetItemsForInvoice(idInvoice);
          ctrlListItems1.RefreshData();
        }
      }
      else if (tabControlsUp.SelectedIndex == 1)
      {
        int idFirm = ctrlSuppliers1.GetActiveIdFirm();
        if (idFirm > 0)
        {
          ctrlListItems1.TypeParent = 2;
          ctrlListItems1.dbItems = Program.DB.GetItemsForFirm(Program.ActiveOrder.idOrder, idFirm);
          ctrlListItems1.RefreshData();
        }
      }
      else if (tabControlsUp.SelectedIndex == 1)
      {
        int idScan = ctrlScanPDFs1.GetActiveIdPDF();
        if (idScan > 0)
        {
          ctrlListItems1.TypeParent = 4;
          ctrlListItems1.dbItems = Program.DB.GetItemsForPDF(idScan);
          ctrlListItems1.RefreshData();
        }
      }
    }


    void ctrlInvoicesList1_myControlChanged(object sender, int iRow, string MenuType)
    {
      if (MenuType == "EDIT")
      {
        ShowForItemsNew(ctrlInvoices1.GetInvoice(iRow));
      }
      if (MenuType == "DETAIL")
      {
        EditOneInvoiceForm(false);
      }
      if (MenuType == "NEWROW")
      {
        InvoiceItemsRefresh(iRow);
      }

    }

    void ctrlSuppliers1_myControlChanged(object sender, int iRow, string MenuType)
    {
      if (MenuType == "EDIT")
      {
      }
      if (MenuType == "DETAIL")
      {
        EditOneDodavatel(iRow);
      }
      if (MenuType == "NEWROW")
      {
        SupplierItemsRefresh(iRow);
      }
    }

    private void EditOneDodavatel(int iRow)
    {
      frmFirmDetail frm = new frmFirmDetail();
      int idFirm = ctrlSuppliers1.GetActiveIdFirmOnRow(iRow);
      frm.Firma = Program.DB.GetFirm(idFirm);
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        RefreshPanels();
      }
    }

    void ctrlScanPDFs1_myControlChanged(object sender, int iRow, string MenuType)
    {
      if (MenuType == "EDIT")
      {
      }
      if (MenuType == "DETAIL")
      {
      }
      if (MenuType == "NEWROW")
      {
        ScanPDFItemsRefresh(iRow);
      }
    }

   




  }
}
