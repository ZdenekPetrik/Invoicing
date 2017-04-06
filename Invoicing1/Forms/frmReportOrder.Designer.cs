namespace Invoicing.Forms
{
  partial class frmReportOrder
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnReport1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnReport1
      // 
      this.btnReport1.Location = new System.Drawing.Point(78, 119);
      this.btnReport1.Name = "btnReport1";
      this.btnReport1.Size = new System.Drawing.Size(128, 23);
      this.btnReport1.TabIndex = 1;
      this.btnReport1.Text = "Závěrečný report";
      this.btnReport1.UseVisualStyleBackColor = true;
      this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
      // 
      // frmReportOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnReport1);
      this.Name = "frmReportOrder";
      this.Text = "frmReportOrder";
      this.Load += new System.EventHandler(this.frmReportOrder_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnReport1;
  }
}