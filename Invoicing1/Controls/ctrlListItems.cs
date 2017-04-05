using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Controls
{
  public partial class ctrlListItems : UserControl
  {
    public int TypeParent = 0;   // 1 Faktura, 2 = Firma, 3 Order, 4 ScanPDF, 5 nic

    public List<wItems> dbItems;

    public ctrlListItems()
    {
      InitializeComponent();
    }

    private void ctrlListItems_Load(object sender, EventArgs e)
    {
      InitData();
      RefreshData();
    }

    private void InitData(){
      if (dbItems == null)
        return;
      dgvListItems.DataSource = dbItems;
    }

    public void RefreshData()
    {
      dgvListItems.DataSource = dbItems;
 //     dgvListItems.Refresh();
      if (dbItems != null)
      {
        dgvListItems.Columns["idInvoiceItem"].Visible = false;
        dgvListItems.Columns["idInvoice"].Visible = false;
        dgvListItems.Columns["idFirm"].Visible = false;
        dgvListItems.Columns["idUnit"].Visible = false;
        dgvListItems.Columns["UnitShort"].Visible = false;
        dgvListItems.EditMode = DataGridViewEditMode.EditProgrammatically;
        dgvListItems.AllowUserToAddRows = false;
        dgvListItems.AllowUserToDeleteRows = false;
        dgvListItems.AllowUserToOrderColumns = true;
      }
    }

    public void RefreshData(List<wItems> II)
    {
      dbItems = II;
      RefreshData();
    }

    
    private void ctrlListItems_Resize(object sender, EventArgs e)
    {
      MyResize();
    }
    private void MyResize()
    {
      dgvListItems.Top = 1;
      dgvListItems.Left = 1;
      dgvListItems.Width = this.Parent.Size.Width;
      dgvListItems.Height = this.Parent.Size.Height;
    }

  }
}
