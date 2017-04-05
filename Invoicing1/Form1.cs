using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnTestEF_Click(object sender, EventArgs e)
    {
      alextradeEntities db = new alextradeEntities();
      string UserName = Environment.UserName;
      Users U;
      try
      {
        var exp = from User in db.Users
                  where User.LoginName == UserName
                  select User;
        if (exp.Count() > 0)
          U = exp.FirstOrDefault();
        else
          U = null;
      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message);
      }

    }
  }
}
