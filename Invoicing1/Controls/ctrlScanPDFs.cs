using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Invoicing.Controls
{
  public partial class ctrlScanPDFs : _ctrlDefault
  {

    public delegate void ControlChanged(object sender, int iRow, string MenuType);   // informuji nadřízený proces, že stiskl, vybral z menu ContextMenu
    public event ControlChanged myControlChanged;


    public ctrlScanPDFs()
    {
      InitializeComponent();
    }



    private void ctrlScanPDFs_Load(object sender, EventArgs e)
    {
      RefreshData();
    }

    public void RefreshData()
    {
      if (ActiveOrder == null)
        return;

      List<ScanPDFForGrid> myGridData = new List<ScanPDFForGrid>();
      List<wScanPDFs> tmpScanPDFs = DB.GetwScanPDFOrderList(ActiveOrder.idOrder);
      for (int i = 1; i <= ActiveOrder.NrSCAN; i++)
      {
        wScanPDFs tmpOneRow = tmpScanPDFs.Find(x => x.ScanIncrement == i);
        ScanPDFForGrid oneRow = new ScanPDFForGrid();
        if (tmpOneRow == null)
        {
          oneRow.isFound = false;
          oneRow.ScanIncrement = i;
          oneRow.HisNumber = "<NaN>";
          oneRow.Poradi = i.ToString("D3");
          myGridData.Add(oneRow);
        }
        else
        {
          oneRow.isFound = false;
          oneRow.ScanIncrement = i;
          oneRow.DateDUZP = tmpOneRow.DateDUZP;
          oneRow.FirmName = tmpOneRow.FirmName;
          oneRow.HisNumber = tmpOneRow.HisNumber;
          oneRow.idInvoice = tmpOneRow.idInvoice;
          oneRow.idOrder = tmpOneRow.idOrder;
          oneRow.idScan = tmpOneRow.idScan;
          oneRow.MyNumber = tmpOneRow.MyNumber;
          oneRow.NrItems = tmpOneRow.NrItems;
          oneRow.Price = tmpOneRow.Price;
          oneRow.Poradi = i.ToString("D3");
          myGridData.Add(oneRow);
        }
      }
      dgvScan.DataSource = myGridData;
      dgvScan.Columns["idScan"].Visible = false;
      dgvScan.Columns["idOrder"].Visible = false;
      dgvScan.Columns["idInvoice"].Visible = false;
      dgvScan.Columns["isFound"].Visible = false;
      dgvScan.EditMode = DataGridViewEditMode.EditProgrammatically;
      dgvScan.AllowUserToAddRows = false;
      dgvScan.AllowUserToDeleteRows = false;
      dgvScan.AllowUserToOrderColumns = true;
      dgvScan.Refresh();
    }

    private void ctrlScanPDFs_Resize(object sender, EventArgs e)
    {
      MyResize();
    }

    private void MyResize()
    {
      dgvScan.Top = 1;
      dgvScan.Left = 1;
      dgvScan.Width = this.Parent.Size.Width;
      dgvScan.Height = this.Parent.Size.Height;
    }

    private void dgvScan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = (int)dgvScan.Rows[e.RowIndex].Cells["ScanIncrement"].Value;
      string myPath = Path.Combine(ActiveOrder.SCANPath, ActiveOrder.SCANPrefix);
      string FileName = myPath + (i).ToString("D3") + ".pdf";
      if (!File.Exists(FileName))
      {
        MessageBox.Show("Nanalezen první soubor " + FileName + "\n Zkontrolujte cestu " + myPath);
        return;
      }
      else
      {
        System.Diagnostics.Process.Start(FileName);
      }

    }

    private void dgvScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }





    public int GetActiveIdPDF()
    {
      if (dgvScan.CurrentCell == null)
        return -1;
      int iRow = dgvScan.CurrentCell.RowIndex;
      if (iRow >= 0)
        return (int)dgvScan.Rows[iRow].Cells["idScan"].Value;
      return -1;
    }

    private void dgvScan_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void dgvScan_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (myControlChanged != null)
      {
        myControlChanged(this, e.RowIndex, "NEWROW");
      }
    }



    public int GetActiveIdScanOnRow(int iRow)
    {
      if (iRow >= 0)
        return(int)dgvScan.Rows[iRow].Cells["idScan"].Value;
      else
        return 0;
    }
  }

  public class ScanPDFForGrid : wScanPDFs
  {
    public bool isFound { get; set; }
    public string Poradi { get; set; }
  }
}
