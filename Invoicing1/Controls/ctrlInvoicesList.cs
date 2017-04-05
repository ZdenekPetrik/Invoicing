using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Invoicing.Controls
{
  public partial class ctrlInvoicesList : _ctrlDefault
  {
    string sortedColumn = "idInvoice";
    ListSortDirection sortedDirection = ListSortDirection.Ascending;
    public List<wInvoices> InvList;

    public delegate void ControlChanged(object sender, int iRow, string MenuType);   // informuji nadřízený proces, že stiskl vybral z menu ContextMenu
    public event ControlChanged myControlChanged;

    private int lastCurrentMouseOverRow = -1;      // pamatuje si posledni vybranou vetu v kontextovém menu

    public ctrlInvoicesList()
    {
      InitializeComponent();
    }

    private void ctrlInvoicesList_Load(object sender, EventArgs e)
    {
      RefreshData();
    }

    public void RefreshData()
    {
      base.RefreshPanel();
      if (ActiveOrder == null)
        return;
      InvList = DB.GetwInvoices(ActiveOrder.idOrder);
      dgInvoices.DataSource = InvList;
      dgInvoices.Columns["idInvoice"].Visible = false;
      dgInvoices.Columns["idOrder"].Visible = false;
      dgInvoices.Columns["idFirm"].Visible = false;
      dgInvoices.Columns["idUser"].Visible = false;
      dgInvoices.Columns["FirmAddress"].Visible = false;
      dgInvoices.Columns["FirmCity"].Visible = false;
      dgInvoices.Columns["FullName"].Visible = false;
      dgInvoices.Columns["FirmZipCode"].Visible = false;
      dgInvoices.Columns["Vat"].Visible = false;
      dgInvoices.Columns["PriceFull"].Visible = false;

      dgInvoices.Refresh();
    }

    private void ctrlInvoicesList_Resize(object sender, EventArgs e)
    {
      MyResize();
    }
    private void MyResize()
    {
      Top = Left = 0;
      Width = this.Parent.Size.Width;
      Height = this.Parent.Size.Height;
      dgInvoices.Top = 1;
      dgInvoices.Left = 1;
      dgInvoices.Width = this.Parent.Size.Width;
      dgInvoices.Height = this.Parent.Size.Height;
      lblTest.Text = "Width/Height" + this.Parent.Size.Width.ToString() + "/" + this.Parent.Size.Height.ToString();
      lblTest.Left = 0;
      lblTest.Top = -30;
    }

    private void dgInvoices_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      DataGridViewColumn newColumn = dgInvoices.Columns[e.ColumnIndex];
      DataGridViewColumn oldColumn = dgInvoices.Columns[sortedColumn];
      if (sortedColumn == newColumn.Name)
      {
        sortedDirection = (sortedDirection == ListSortDirection.Descending) ? ListSortDirection.Ascending : ListSortDirection.Descending;
      }
      else
      {
        sortedDirection = ListSortDirection.Ascending;
        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
      }

      // Sort the selected column.
      InvList = InvList.OrderBy(newColumn.Name + (sortedDirection == ListSortDirection.Ascending ? "" : " DESC")).AsEnumerable().Cast<wInvoices>().ToList();
      dgInvoices.DataSource = InvList;
      DataGridViewColumn newColumn1 = dgInvoices.Columns[e.ColumnIndex];
      newColumn1.HeaderCell.SortGlyphDirection =
          sortedDirection == ListSortDirection.Ascending ?
          SortOrder.Ascending : SortOrder.Descending;
      sortedColumn = newColumn.Name;

    }

    private void dgInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      foreach (DataGridViewColumn column in dgInvoices.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Programmatic;
      }

    }


    public wInvoices GetActiveInvoice()
    {
      int iRow = dgInvoices.CurrentCell.RowIndex;
      if (iRow >= 0)
        return InvList[iRow];
      return null;
    }
    public int GetActiveIdInvoice()
    {
      if (dgInvoices.CurrentCell == null)
        return -1;
      int iRow = dgInvoices.CurrentCell.RowIndex;
      if (iRow >= 0)
        return InvList[iRow].idInvoice;
      return -1;
    }

    public wInvoices GetInvoice(int iRow)
    {
      return InvList[iRow];
    }
    public int GetActiveIdInvoiceOnRow(int iRow)
    {
      if (iRow >= 0 && InvList != null && InvList.Count > 0)
        return InvList[iRow].idInvoice;
      else
        return 0;
    }


    private void dgInvoices_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        int currentMouseOverRow = dgInvoices.HitTest(e.X, e.Y).RowIndex;
        lastCurrentMouseOverRow = currentMouseOverRow;
        if (currentMouseOverRow >= 0)
        {
          wInvoices Inv = InvList[currentMouseOverRow];
          ContextMenu m = new ContextMenu();
          MenuItem mnuDetail = new MenuItem(string.Format("Detail Faktury  {0}", Inv.MyNumber.ToString()));
          MenuItem mnuEdit = new MenuItem(string.Format("Edituj Položky faktury {0}", Inv.MyNumber.ToString()));
          mnuDetail.Click += mnuDetail_Click;
          mnuEdit.Click += mnuEdit_Click;
          m.MenuItems.Add(mnuDetail);
          m.MenuItems.Add(mnuEdit);
          m.Show(dgInvoices, new Point(e.X, e.Y));
        }
      }
    }

    void mnuEdit_Click(object sender, EventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, lastCurrentMouseOverRow, "EDIT");
      }
    }

    private void mnuDetail_Click(object sender, EventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, lastCurrentMouseOverRow, "DETAIL");
      }
    }

    private void dgInvoices_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, lastCurrentMouseOverRow, "DETAIL");
      }

    }

    private void dgInvoices_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, e.RowIndex, "NEWROW");
      }
    }

    private void dgInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      foreach (DataGridViewRow Myrow in dgInvoices.Rows)
      {
        int? StateValue = (int?)Myrow.Cells["StateValue"].Value;
        if (StateValue == 2)
          Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
        else if (StateValue == 3)
          Myrow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
        else
          Myrow.DefaultCellStyle.BackColor = Color.White;
      }
    }

    private void dgInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

   }
}
