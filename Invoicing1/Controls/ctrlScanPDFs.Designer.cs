namespace Invoicing.Controls
{
  partial class ctrlScanPDFs
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
      this.dgvScan = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvScan
      // 
      this.dgvScan.AllowUserToAddRows = false;
      this.dgvScan.AllowUserToDeleteRows = false;
      this.dgvScan.AllowUserToResizeRows = false;
      this.dgvScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvScan.Location = new System.Drawing.Point(43, 3);
      this.dgvScan.Name = "dgvScan";
      this.dgvScan.ReadOnly = true;
      this.dgvScan.Size = new System.Drawing.Size(211, 150);
      this.dgvScan.TabIndex = 0;
      this.dgvScan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_CellContentClick);
      this.dgvScan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_CellDoubleClick);
      this.dgvScan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_RowEnter);
      this.dgvScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvScan_MouseClick);
      // 
      // ctrlScanPDFs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvScan);
      this.Name = "ctrlScanPDFs";
      this.Size = new System.Drawing.Size(1017, 178);
      this.Load += new System.EventHandler(this.ctrlScanPDFs_Load);
      this.Resize += new System.EventHandler(this.ctrlScanPDFs_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvScan;
  }
}
