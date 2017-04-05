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
  public partial class ctrlSuppliers : _ctrlDefault
  {

    List<wFirms> dbSuppliers;
    string sortedColumn = "Name";
    ListSortDirection sortedDirection = ListSortDirection.Ascending;
    public delegate void ControlChanged(object sender, int iRow, string MenuType);   // informuji nadřízený proces, že stiskl, vybral z menu ContextMenu
    public event ControlChanged myControlChanged;
    private int lastCurrentMouseOverRow = -1;      // pamatuje si posledni vybranou vetu v kontextovém menu


    public ctrlSuppliers()
    {
      InitializeComponent();
    }

    private void ctrlSuppliers_Load(object sender, EventArgs e)
    {
      RefreshData();
    }

    private void ctrlSuppliers_Resize(object sender, EventArgs e)
    {
      MyResize();
    }
    private void MyResize()
    {
      dgvSuppliers.Top = 0;
      dgvSuppliers.Left = 0;
      dgvSuppliers.Width = this.Parent.Size.Width;
      dgvSuppliers.Height = this.Parent.Size.Height;

    }
    public void RefreshData()
    {
      if (ActiveOrder == null)
        return;
      dbSuppliers = DB.GetSupplierInOrder(ActiveOrder.idOrder);
      dgvSuppliers.DataSource = dbSuppliers;
      dgvSuppliers.Refresh();
      dgvSuppliers.Columns["idFirm"].Visible = false;
      dgvSuppliers.Columns["idFirmCategory"].Visible = false;
      sortedColumn = "Name";
      DataGridViewColumn Column = dgvSuppliers.Columns[sortedColumn];
      Column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;

    }

    private void dgvSuppliers_Sorted(object sender, EventArgs e)
    {

    }

    private void dgvSuppliers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      // Put each of the columns into programmatic sort mode.
      foreach (DataGridViewColumn column in dgvSuppliers.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Programmatic;
      }

    }

    private void dgvSuppliers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      DataGridViewColumn newColumn = dgvSuppliers.Columns[e.ColumnIndex];
      DataGridViewColumn oldColumn = dgvSuppliers.Columns[sortedColumn];
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
      dbSuppliers = dbSuppliers.OrderBy(newColumn.Name + (sortedDirection == ListSortDirection.Ascending ? "" : " DESC")).AsEnumerable().Cast<wFirms>().ToList();
      dgvSuppliers.DataSource = dbSuppliers;
      DataGridViewColumn newColumn1 = dgvSuppliers.Columns[e.ColumnIndex];
      newColumn1.HeaderCell.SortGlyphDirection =
          sortedDirection == ListSortDirection.Ascending ?
          SortOrder.Ascending : SortOrder.Descending;
      sortedColumn = newColumn.Name;

    }

    public int GetActiveIdFirm()
    {
      if (dgvSuppliers.CurrentCell == null)
        return -1;
      int iRow = dgvSuppliers.CurrentCell.RowIndex;
      if (iRow >= 0)
        return dbSuppliers[iRow].idFirm;
      return -1;
    }
    public int GetActiveIdFirmOnRow(int iRow)
    {
      if (iRow >= 0)
        return dbSuppliers[iRow].idFirm;
      else
        return 0;

    }



    private void dgvSuppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, e.RowIndex, "NEWROW");
      }
    }

    private void mnuDetail_Click(object sender, EventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, lastCurrentMouseOverRow, "DETAIL");
      }
    }


    private void dgvSuppliers_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        int currentMouseOverRow = dgvSuppliers.HitTest(e.X, e.Y).RowIndex;
        lastCurrentMouseOverRow = currentMouseOverRow;
        if (currentMouseOverRow >= 0)
        {
          wFirms F = dbSuppliers[currentMouseOverRow];
          ContextMenu m = new ContextMenu();
          MenuItem mnuDetail = new MenuItem(string.Format("Detail Firmy  {0}", F.Name));
          mnuDetail.Click += mnuDetail_Click;
          m.MenuItems.Add(mnuDetail);
          m.Show(dgvSuppliers, new Point(e.X, e.Y));
        }
      }
    }

    private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
