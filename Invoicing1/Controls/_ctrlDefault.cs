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
  public partial class _ctrlDefault : UserControl
  {
    public CDatabase DB;
    public CUser LoginUser;
    public wOrders ActiveOrder;

    public _ctrlDefault()
    {
      InitializeComponent();
      RefreshPanel();
    }

    private void _ctrlDefault_Load(object sender, EventArgs e)
    {
      Font myfont = new Font("Times New Roman", 12.0f);
      foreach (var c in this.Controls)
      {
        if (c is TextBox)
        {
          ((TextBox)c).Font = myfont;
        }
      }

    }

    public void RefreshPanel() {
      DB = Program.DB;
      LoginUser = Program.LoginUser;
      ActiveOrder = Program.ActiveOrder;
    }
  }
}
