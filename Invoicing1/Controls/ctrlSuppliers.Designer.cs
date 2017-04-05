namespace Invoicing.Controls
{
  partial class ctrlSuppliers
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
      this.dgvSuppliers = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvSuppliers
      // 
      this.dgvSuppliers.AllowUserToAddRows = false;
      this.dgvSuppliers.AllowUserToDeleteRows = false;
      this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSuppliers.Location = new System.Drawing.Point(3, 3);
      this.dgvSuppliers.Name = "dgvSuppliers";
      this.dgvSuppliers.ReadOnly = true;
      this.dgvSuppliers.Size = new System.Drawing.Size(49, 70);
      this.dgvSuppliers.TabIndex = 0;
      this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
      this.dgvSuppliers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliers_ColumnHeaderMouseClick);
      this.dgvSuppliers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSuppliers_DataBindingComplete);
      this.dgvSuppliers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_RowEnter);
      this.dgvSuppliers.Sorted += new System.EventHandler(this.dgvSuppliers_Sorted);
      this.dgvSuppliers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSuppliers_MouseClick);
      // 
      // ctrlSuppliers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvSuppliers);
      this.Name = "ctrlSuppliers";
      this.Size = new System.Drawing.Size(565, 150);
      this.Load += new System.EventHandler(this.ctrlSuppliers_Load);
      this.Resize += new System.EventHandler(this.ctrlSuppliers_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvSuppliers;
  }
}
