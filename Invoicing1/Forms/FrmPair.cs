using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Linq.Dynamic;
using Invoicing.Modul;

namespace Invoicing.Forms
{
  public partial class FrmPair : _frmDefault
  {
    string sortedColumnItems = "Den";
    ListSortDirection sortedDirectionItems = ListSortDirection.Ascending;
    string sortedColumnProduct = "Druh";
    ListSortDirection sortedDirectionProduct = ListSortDirection.Ascending;

    List<wProductTable> ActiveProductTable;
    List<wPair> PairItems;
    int idProductAkt = -1;
    int idInvoiceItemAkt = -1;


    public FrmPair()
    {
      InitializeComponent();
    }

    private void FrmPair_Load(object sender, EventArgs e)
    {
      ActiveProductTable = DB.GetProducts();
      PairItems = DB.GetPairForOrder(ActiveOrder.idOrder);
      LoadProduct();
      LoadItems();

      cmbPairType.DataSource = DB.GetPairType();
      cmbPairType.DisplayMember = "PairType1";
      cmbPairType.ValueMember = "idPairType";
      cmbPairType.SelectedIndex = 0;
      MyResize();
      lblPairStatus.Text = "Spárováno: " + PairItems.FindAll(x => x.idPair != null).Count.ToString() + "/" + PairItems.Count.ToString();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      string[] S = txtSearchString.Text.Split(' ');
      ActiveProductTable = DB.GetProducts(S);
      LoadProduct2();
    }

    private void LoadProduct()
    {
      gvProdukty.AutoGenerateColumns = false;
      DataGridViewTextBoxColumn[] Cl = new DataGridViewTextBoxColumn[8];
      for (int i = 0; i < Cl.Count(); i++)
        Cl[i] = new DataGridViewTextBoxColumn();
      Cl[0].Name = "Product";
      Cl[0].DataPropertyName = "Product";
      Cl[1].Name = "Mn.";
      Cl[1].DataPropertyName = "Quantity";
      Cl[2].Name = "Jedn.";
      Cl[2].DataPropertyName = "UnitShort";
      Cl[3].Name = "Druh";
      Cl[3].DataPropertyName = "Druh";
      Cl[4].Name = "Komodita";
      Cl[4].DataPropertyName = "Komodita";
      Cl[5].Name = "Podkomodita";
      Cl[5].DataPropertyName = "Podkomodita";
      Cl[6].Name = "Priznak";
      Cl[6].DataPropertyName = "Priznak";
      Cl[7].Name = "idProduct";
      Cl[7].DataPropertyName = "idProduct";

      //   Cl[7].Visible = false;
      foreach (DataGridViewTextBoxColumn dgvColumn in Cl)
        gvProdukty.Columns.Add(dgvColumn);

      gvProdukty.DataSource = ActiveProductTable;
      gvProdukty.EditMode = DataGridViewEditMode.EditProgrammatically;
      gvProdukty.AllowUserToAddRows = false;
      gvProdukty.AllowUserToDeleteRows = false;
      gvProdukty.AllowUserToOrderColumns = true;
      gvProdukty.SetColumnOrderExt();
      ReadPriceProduct(0);

      //     gvProdukty.Refresh();
    }

    private void LoadProduct2()
    {
      gvProdukty.DataSource = ActiveProductTable;
      //      gvPair.Refresh();
      ReadPriceProduct(0);
    }

    private void LoadItems()
    {
      gvPair.AutoGenerateColumns = false;
      DataGridViewTextBoxColumn[] Cl = new DataGridViewTextBoxColumn[16];
      for (int i = 0; i < Cl.Count(); i++)
        Cl[i] = new DataGridViewTextBoxColumn();
      Cl[0].Name = "Název";
      Cl[0].DataPropertyName = "ItemName";
      Cl[1].Name = "Mn.";
      Cl[1].DataPropertyName = "Quantity";
      Cl[2].Name = "Jedn.";
      Cl[2].DataPropertyName = "UnitShort";
      Cl[3].Name = "Dodavatel";
      Cl[3].DataPropertyName = "FirmName";
      Cl[4].Name = "Den";
      Cl[4].DataPropertyName = "DateDUZP";
      Cl[4].DefaultCellStyle.Format = "dd.MM";
      Cl[5].Name = "Týden";
      Cl[5].DataPropertyName = "InvoiceWeek";
      Cl[6].Name = "Jedn. Cena";
      Cl[6].DataPropertyName = "BasePriceBezDPH";
      Cl[6].DefaultCellStyle.Format = "N2";
      Cl[7].Name = "Celkem";
      Cl[7].DataPropertyName = "PriceBezDPH";
      Cl[7].DefaultCellStyle.Format = "N2";
      Cl[8].Name = "Pair-Cena";
      Cl[8].DataPropertyName = "PairPrice";
      Cl[9].Name = "Rozdíl";
      Cl[9].DataPropertyName = "Rozdil";
      Cl[9].DefaultCellStyle.Format = "0\\%";
      Cl[10].Name = "Pair-Type";
      Cl[10].DataPropertyName = "PairType";
      Cl[11].Name = "P-Produkt";
      Cl[11].DataPropertyName = "Product";

      Cl[12].Name = "idInvoiceItem";
      Cl[12].DataPropertyName = "idInvoiceItem";
      Cl[12].Visible = false;
      Cl[13].Name = "idPair";
      Cl[13].DataPropertyName = "idPair";
      Cl[13].Visible = false;
      Cl[14].Name = "idPairType";
      Cl[14].DataPropertyName = "idPairType";
      Cl[14].Visible = false;
      Cl[15].Name = "idProduct";
      Cl[15].DataPropertyName = "idProduct";
      Cl[15].Visible = false;

      gvPair.DataSource = PairItems;
      foreach (DataGridViewTextBoxColumn dgvColumn in Cl)
        gvPair.Columns.Add(dgvColumn);
      DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
      btnCol.HeaderText = "PDF";
      btnCol.DataPropertyName = "idInvoice";
      btnCol.Name = "PDF";
      gvPair.Columns.Add(btnCol);
      gvPair.EditMode = DataGridViewEditMode.EditProgrammatically;
      gvPair.AllowUserToAddRows = false;
      gvPair.AllowUserToDeleteRows = false;
      gvPair.AllowUserToOrderColumns = true;
      gvPair.SetColumnOrderExt();
      // gvPair.Refresh();
    }

    private void FrmPair_Resize(object sender, EventArgs e)
    {
      MyResize();
    }

    private void MyResize()
    {
      splitContainer1.Left = 0;
      splitContainer1.Top = 0;
      splitContainer1.Width = ClientRectangle.Width;
      splitContainer1.Height = ClientRectangle.Height;
      ResizeLeftPanel();
      ResizeRightPanel();
    }

    private void ResizeLeftPanel()
    {
      gvPair.Top = 1;
      gvPair.Left = 1;
      gvPair.Width = splitContainer1.Panel1.Width - 1;
      gvPair.Height = splitContainer1.Panel1.Height - (30);
      lblPairRow.Left = 1;
      lblPairRow.Top = splitContainer1.Panel1.Height - 22;
      lblPairStatus.Left = 100;
      lblPairStatus.Top = splitContainer1.Panel1.Height - 22;
      btnPairDetail.Left = splitContainer1.Panel1.Width - (btnPairDetail.Width + 10);
      btnPairDetail.Top = splitContainer1.Panel1.Height - 25;

    }
    private void ResizeRightPanel()
    {
      txtSearchString.Left = 20;
      txtSearchString.Top = 10;
      txtSearchString.Width = splitContainer1.Panel2.Width - 160;
      btnSearch.Left = txtSearchString.Width + 20;
      btnSearch.Top = 9;
      gvProdukty.Top = 35;
      gvProdukty.Left = 1;
      gvProdukty.Width = splitContainer1.Panel2.Width - 1;
      gvProdukty.Height = splitContainer1.Panel2.Height - (100 + panel1.Height);
      panel1.Left = 1;
      panel1.Top = splitContainer1.Panel2.Height - (panel1.Height + 40);
      btnPorovnej.Top = splitContainer1.Panel2.Height - 30;
      btnPorovnej.Left = 1;
      cmbPairType.Top = btnPorovnej.Top;
      cmbPairType.Left = btnPorovnej.Width + 20;
      btnCancel.Top = splitContainer1.Panel2.Height - 30;
      btnCancel.Left = splitContainer1.Panel2.Width - 120;


      //      txtSearchString.Text = splitContainer1.Panel1.Width.ToString() + "/" + splitContainer1.Panel2.Width.ToString();
    }

    private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
    {
      ResizeLeftPanel();
      ResizeRightPanel();
    }

    private void cmbPairType_DisplayMemberChanged(object sender, EventArgs e)
    {
      txtSearchString.Text = cmbPairType.SelectedText;
    }

    private void btnPorovnej_Click(object sender, EventArgs e)
    {
      frmCommitPair frm = new frmCommitPair();
      frm.idInvoiceItem = idInvoiceItemAkt;
      frm.idProduct = idProductAkt;
      frm.idPairType = ((int)cmbPairType.SelectedValue);
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        RefreshOneRowInvoicePair();
      }
    }

    private void gvPair_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      DataGridViewColumn newColumn = gvPair.Columns[e.ColumnIndex];
      DataGridViewColumn oldColumn = gvPair.Columns[sortedColumnItems];
      if (sortedColumnItems == newColumn.Name)
      {
        sortedDirectionItems = (sortedDirectionItems == ListSortDirection.Descending) ? ListSortDirection.Ascending : ListSortDirection.Descending;
      }
      else
      {
        sortedDirectionItems = ListSortDirection.Ascending;
        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
      }

      // Sort the selected column.
      PairItems = PairItems.OrderBy(newColumn.DataPropertyName + (sortedDirectionItems == ListSortDirection.Ascending ? "" : " DESC")).AsEnumerable().Cast<wPair>().ToList();
      gvPair.DataSource = PairItems;
      DataGridViewColumn newColumn1 = gvPair.Columns[e.ColumnIndex];
      newColumn1.HeaderCell.SortGlyphDirection =
          sortedDirectionItems == ListSortDirection.Ascending ?
          SortOrder.Ascending : SortOrder.Descending;
      sortedColumnItems = newColumn.Name;

    }

    private void gvPair_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      foreach (DataGridViewColumn column in gvPair.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Programmatic;
      }


    }

    private void gvPair_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0 || e.ColumnIndex != gvPair.Columns["PDF"].Index)
        return;
      int Id = (int)gvPair[e.ColumnIndex, e.RowIndex].Value;

      frmAddInvoice frm = new frmAddInvoice();
      frm.Mode = 4;
      frm.Inv = DB.GetInvoice(Id);
      frm.ShowDialog(this);
    }

    private void gvProdukty_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void gvProdukty_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      DataGridViewColumn newColumn = gvProdukty.Columns[e.ColumnIndex];
      DataGridViewColumn oldColumn = gvProdukty.Columns[sortedColumnProduct];
      if (sortedColumnProduct == newColumn.Name)
      {
        sortedDirectionProduct = (sortedDirectionProduct == ListSortDirection.Descending) ? ListSortDirection.Ascending : ListSortDirection.Descending;
      }
      else
      {
        sortedDirectionProduct = ListSortDirection.Ascending;
        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
      }

      // Sort the selected column.
      ActiveProductTable = ActiveProductTable.OrderBy(newColumn.DataPropertyName + (sortedDirectionProduct == ListSortDirection.Ascending ? "" : " DESC")).AsEnumerable().Cast<wProductTable>().ToList();
      gvProdukty.DataSource = ActiveProductTable;
      DataGridViewColumn newColumn1 = gvProdukty.Columns[e.ColumnIndex];
      newColumn1.HeaderCell.SortGlyphDirection =
          sortedDirectionProduct == ListSortDirection.Ascending ?
          SortOrder.Ascending : SortOrder.Descending;
      sortedColumnProduct = newColumn.Name;

    }

    private void gvProdukty_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      foreach (DataGridViewColumn column in gvPair.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Programmatic;
      }


    }

    private void gvProdukty_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      idProductAkt = -1;
      if (e.RowIndex >= 0 && gvProdukty.RowCount > e.RowIndex)
      {
        ReadPriceProduct(e.RowIndex);
      }
    }
    private void gvPair_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      idInvoiceItemAkt = -1;
      btnPairDetail.Enabled = false;
      if (e.RowIndex >= 0 && gvPair.RowCount > e.RowIndex + 1)
      {
        idInvoiceItemAkt = (int)gvPair["idInvoiceItem", e.RowIndex].Value;
        btnPairDetail.Enabled = (gvPair["idProduct", e.RowIndex].Value != null);
      }
      lblPairRow.Text = e.RowIndex.ToString() + "/" + PairItems.Count.ToString();
    }

    private void ReadPriceProduct(int iRow)
    {
      wWeekMinPricesTemp Min = null;
      wWeekPricesTemp Avg = null;
      if (iRow >= 0 && gvProdukty.RowCount > iRow)
      {
        idProductAkt = (int)gvProdukty["idProduct", iRow].Value;
        Min = DB.WeekMinPricesTemp(idProductAkt);
        Avg = DB.WeekPricesTemp(idProductAkt);
      }
      if (Avg == null)
      {
        lblAvg1.Text = "-";
        lblAvg2.Text = "-";
        lblAvg3.Text = "-";
        lblAvg4.Text = "-";
        lblAvg5.Text = "-";
      }
      else
      {
        lblAvg1.Text = Helper.DoubleToMoneyExt(Avg.C44);
        lblAvg2.Text = Helper.DoubleToMoneyExt(Avg.C45);
        lblAvg3.Text = Helper.DoubleToMoneyExt(Avg.C46);
        lblAvg4.Text = Helper.DoubleToMoneyExt(Avg.C47);
        lblAvg5.Text = Helper.DoubleToMoneyExt(Avg.C48);
      }
      if (Min == null)
      {
        lblMin1.Text = "-";
        lblMin2.Text = "-";
        lblMin3.Text = "-";
        lblMin4.Text = "-";
        lblMin5.Text = "-";
      }
      else
      {
        lblMin1.Text = Helper.DoubleToMoneyExt(Min.C44);
        lblMin2.Text = Helper.DoubleToMoneyExt(Min.C45);
        lblMin3.Text = Helper.DoubleToMoneyExt(Min.C46);
        lblMin4.Text = Helper.DoubleToMoneyExt(Min.C47);
        lblMin5.Text = Helper.DoubleToMoneyExt(Min.C48);
      }
    }

    private void btnProductDetail_Click(object sender, EventArgs e)
    {
      frmProductDetail frm = new frmProductDetail();
      frm.Obdobi = ActiveOrder.OrderDate ?? DateTime.Now;
      frm.IdProduct = idProductAkt;
      frm.ShowDialog();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (DB.DeletePair(idInvoiceItemAkt))
        RefreshOneRowInvoicePair();
      else
        MessageBox.Show(DB.sErr);
    }

    void RefreshOneRowInvoicePair()
    {
      Point akt = new Point(gvPair.CurrentCell.RowIndex, gvPair.CurrentCell.ColumnIndex);
      PairItems = DB.GetPairForOrder(ActiveOrder.idOrder);
      DataGridViewColumn sortedColumn = gvPair.Columns[sortedColumnItems];
      PairItems = PairItems.OrderBy(sortedColumn.DataPropertyName + (sortedDirectionItems == ListSortDirection.Ascending ? "" : " DESC")).AsEnumerable().Cast<wPair>().ToList();
      gvPair.DataSource = PairItems;
      /*
      for (int i = 0; i < gvPair.Rows.Count(); i++) {
        if (((int)gvPair["idInvoiceItem", i].Value) == idInvoiceItemAkt) {
          gvPair.CurrentCell = akt;  //  gvPair.Rows[i].Cells[0];
          break;
        }
      }
       * */
      gvPair.CurrentCell = gvPair[akt.Y, akt.X];
      lblPairStatus.Text = "Spárováno: " + PairItems.FindAll(x => x.idPair != null).Count.ToString() + "/" + PairItems.Count.ToString();
    }

    private void gvPair_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      foreach (DataGridViewRow Myrow in gvPair.Rows)
      {
        int? idPair = (int?)Myrow.Cells["idPair"].Value;
        int? idPairType = (int?)Myrow.Cells["idPairType"].Value;

        if (idPair == null || idPair <= 0)
        {
          Myrow.DefaultCellStyle.BackColor = Color.White;
        }
        else
        {
          if (idPairType == 1)
          {
            Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
          }
          else
          {
            Myrow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
          }
          //         var value1 = (double?)Myrow.Cells["Jedn. Cena"].Value;
          //         var value2 = (double?)Myrow.Cells["Pair-Cena"].Value;
          //         if (!(value1 == null || value2 == null || (value2 ?? 0) == 0)){
          //          double Percent = 100 * ((value1??0) / (value2??1));
          //           Percent = 100 - Percent;
          if (Myrow.Cells["Rozdíl"] != null)
          {
            double Percent = (double)Myrow.Cells["Rozdíl"].Value;
            if (Percent > 20)
              Myrow.Cells["Rozdíl"].Style.ForeColor = Color.OrangeRed;
            else
              Myrow.Cells["Rozdíl"].Style.ForeColor = Color.Black;
          }
          else
          {
            Myrow.Cells["Rozdíl"].Value = "";
          }
        }
      }
    }


    private void btnPairDetail_Click(object sender, EventArgs e)
    {
      frmCommitPair frm = new frmCommitPair();
      frm.idInvoiceItem = idInvoiceItemAkt;
      frm.idProduct = (int)gvPair["idProduct", gvPair.CurrentCell.RowIndex].Value;
      frm.idPairType = (int)gvPair["idPairType", gvPair.CurrentCell.RowIndex].Value;
      if (System.Windows.Forms.DialogResult.Yes == frm.ShowDialog(this))
      {
        RefreshOneRowInvoicePair();
      }

    }

    private void gvPair_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }



  }

}
