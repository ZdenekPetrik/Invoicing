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
  public partial class frmAbout : Form
  {
    public frmAbout()
    {
      InitializeComponent();
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      // https://groups.google.com/d/forum/soap1group
      txtVersionPopis.Text = "1.0.5. Reporting zakázky - Export do Excelu, zrychlení hledání párování na stick ENTER, změna barvy u sloupce procent";


    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
