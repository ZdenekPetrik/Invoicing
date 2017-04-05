using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingExportImport
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void menu_ImportAbasto_Click(object sender, EventArgs e)
    {
      OpenFileDialog opf = new OpenFileDialog();
      DialogResult result = opf.ShowDialog();
      if (result == DialogResult.OK) {
        MessageBox.Show(opf.FileName);
      }
    }
  }
}
