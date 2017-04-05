namespace Invoicing.Controls
{
  partial class ctrlItem
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblNrItem = new System.Windows.Forms.Label();
      this.txtScan = new System.Windows.Forms.TextBox();
      this.cmbUnit = new System.Windows.Forms.ComboBox();
      this.txtCena = new System.Windows.Forms.TextBox();
      this.txtJednotkovaCena = new System.Windows.Forms.TextBox();
      this.txtPocet = new System.Windows.Forms.TextBox();
      this.txtNazev = new System.Windows.Forms.TextBox();
      this.lblNrInvoice = new System.Windows.Forms.Label();
      this.cmbDPH = new System.Windows.Forms.ComboBox();
      this.txtCenaBezDPH = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblNrItem
      // 
      this.lblNrItem.AutoSize = true;
      this.lblNrItem.Location = new System.Drawing.Point(90, 3);
      this.lblNrItem.Name = "lblNrItem";
      this.lblNrItem.Size = new System.Drawing.Size(16, 13);
      this.lblNrItem.TabIndex = 8;
      this.lblNrItem.Text = "1.";
      // 
      // txtScan
      // 
      this.txtScan.Location = new System.Drawing.Point(47, 0);
      this.txtScan.Name = "txtScan";
      this.txtScan.Size = new System.Drawing.Size(31, 20);
      this.txtScan.TabIndex = 0;
      // 
      // cmbUnit
      // 
      this.cmbUnit.FormattingEnabled = true;
      this.cmbUnit.Location = new System.Drawing.Point(677, 0);
      this.cmbUnit.Name = "cmbUnit";
      this.cmbUnit.Size = new System.Drawing.Size(46, 21);
      this.cmbUnit.TabIndex = 5;
      // 
      // txtCena
      // 
      this.txtCena.Location = new System.Drawing.Point(594, 0);
      this.txtCena.Name = "txtCena";
      this.txtCena.Size = new System.Drawing.Size(77, 20);
      this.txtCena.TabIndex = 4;
      this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCena_KeyUp);
      this.txtCena.Leave += new System.EventHandler(this.txtCena_Leave);
      // 
      // txtJednotkovaCena
      // 
      this.txtJednotkovaCena.Location = new System.Drawing.Point(462, 0);
      this.txtJednotkovaCena.Name = "txtJednotkovaCena";
      this.txtJednotkovaCena.Size = new System.Drawing.Size(78, 20);
      this.txtJednotkovaCena.TabIndex = 2;
      this.txtJednotkovaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtJednotkovaCena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJednotkovaCena_KeyUp);
      this.txtJednotkovaCena.Leave += new System.EventHandler(this.txtJednotkovaCena_Leave);
      // 
      // txtPocet
      // 
      this.txtPocet.Location = new System.Drawing.Point(546, 0);
      this.txtPocet.Name = "txtPocet";
      this.txtPocet.Size = new System.Drawing.Size(42, 20);
      this.txtPocet.TabIndex = 3;
      this.txtPocet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPocet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPocet_KeyUp);
      this.txtPocet.Leave += new System.EventHandler(this.txtPocet_Leave);
      // 
      // txtNazev
      // 
      this.txtNazev.Location = new System.Drawing.Point(112, 0);
      this.txtNazev.Name = "txtNazev";
      this.txtNazev.Size = new System.Drawing.Size(292, 20);
      this.txtNazev.TabIndex = 1;
      this.txtNazev.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNazev_KeyUp);
      // 
      // lblNrInvoice
      // 
      this.lblNrInvoice.AutoSize = true;
      this.lblNrInvoice.Location = new System.Drawing.Point(4, 4);
      this.lblNrInvoice.Name = "lblNrInvoice";
      this.lblNrInvoice.Size = new System.Drawing.Size(37, 13);
      this.lblNrInvoice.TabIndex = 0;
      this.lblNrInvoice.Text = "00000";
      // 
      // cmbDPH
      // 
      this.cmbDPH.FormattingEnabled = true;
      this.cmbDPH.Location = new System.Drawing.Point(410, 0);
      this.cmbDPH.Name = "cmbDPH";
      this.cmbDPH.Size = new System.Drawing.Size(46, 21);
      this.cmbDPH.TabIndex = 9;
      this.cmbDPH.SelectedIndexChanged += new System.EventHandler(this.cmbDPH_SelectedIndexChanged);
      this.cmbDPH.Leave += new System.EventHandler(this.cmbDPH_Leave);
      // 
      // txtCenaBezDPH
      // 
      this.txtCenaBezDPH.Enabled = false;
      this.txtCenaBezDPH.Location = new System.Drawing.Point(729, 0);
      this.txtCenaBezDPH.Name = "txtCenaBezDPH";
      this.txtCenaBezDPH.Size = new System.Drawing.Size(77, 20);
      this.txtCenaBezDPH.TabIndex = 10;
      this.txtCenaBezDPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCenaBezDPH.TextChanged += new System.EventHandler(this.txtCenaBezDPH_TextChanged);
      // 
      // ctrlItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtCenaBezDPH);
      this.Controls.Add(this.cmbDPH);
      this.Controls.Add(this.lblNrItem);
      this.Controls.Add(this.txtScan);
      this.Controls.Add(this.cmbUnit);
      this.Controls.Add(this.txtCena);
      this.Controls.Add(this.txtJednotkovaCena);
      this.Controls.Add(this.txtPocet);
      this.Controls.Add(this.txtNazev);
      this.Controls.Add(this.lblNrInvoice);
      this.Name = "ctrlItem";
      this.Size = new System.Drawing.Size(818, 24);
      this.Load += new System.EventHandler(this.ctrlAddItem_Load);
      this.Leave += new System.EventHandler(this.ctrlItem_Leave);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblNrInvoice;
    private System.Windows.Forms.TextBox txtNazev;
    private System.Windows.Forms.TextBox txtPocet;
    private System.Windows.Forms.TextBox txtJednotkovaCena;
    private System.Windows.Forms.TextBox txtCena;
    private System.Windows.Forms.ComboBox cmbUnit;
    private System.Windows.Forms.TextBox txtScan;
    private System.Windows.Forms.Label lblNrItem;
    private System.Windows.Forms.ComboBox cmbDPH;
    private System.Windows.Forms.TextBox txtCenaBezDPH;
  }
}
