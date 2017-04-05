using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Forms
{
  public partial class frmProductDetail : _frmDefault
  {
    public int IdProduct;
    public DateTime Obdobi;
    private DateTime myObdobiFrom { get { return Obdobi.Date.AddDays(Obdobi.Day - 1); } }
    private DateTime myObdobiTo { get { return myObdobiFrom.AddMonths(1).AddDays(-1); } }
    private wProductTable wP;
    public frmProductDetail()
    {
      InitializeComponent();
    }


    private void frmProductDetail_Load(object sender, EventArgs e)
    {
      GetTable();
      wP = DB.GetProductTable(IdProduct);
      dgvProduktPrice.SetColumnOrderExt();
      GetProductInfo();
      dtOrderSeason.Value = Obdobi;
    }

    private void GetProductInfo()
    {
      lblProductName.Text = wP.Product;
      lblProductDruh.Text = wP.Druh;
      lblProductKomodita.Text = wP.Komodita;
      lblProductPodkomodita.Text = wP.Podkomodita;
      lblPriznak.Text = wP.Priznak;
      lblMark.Text = wP.Mark;
      lblQuantity.Text = wP.Quantity.ToString();
      lblUnit.Text = wP.UnitName;

    }

    private void GetTable()
    {
      SqlConnection conn = new SqlConnection(DB.MyCN);
      try
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand("supplier.GetDayProductPrice", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p1 = new SqlParameter("@DateFrom", SqlDbType.DateTime); p1.Value = myObdobiFrom;
        SqlParameter p2 = new SqlParameter("@DateTo", SqlDbType.DateTime); p2.Value = myObdobiTo;
        SqlParameter p3 = new SqlParameter("@idProduct", SqlDbType.Int); p3.Value = IdProduct;
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        adapter.SelectCommand = cmd;
        adapter.Fill(dt);
        dgvProduktPrice.DataSource = dt;
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        if (conn != null)
          conn.Close();
      }
    }

    private void dgvProduktPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
