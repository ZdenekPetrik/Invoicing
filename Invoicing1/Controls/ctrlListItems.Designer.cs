namespace Invoicing.Controls
{
  partial class ctrlListItems
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
      this.dgvListItems = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvListItems
      // 
      this.dgvListItems.AllowUserToAddRows = false;
      this.dgvListItems.AllowUserToDeleteRows = false;
      this.dgvListItems.AllowUserToResizeRows = false;
      this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListItems.Location = new System.Drawing.Point(0, -3);
      this.dgvListItems.Name = "dgvListItems";
      this.dgvListItems.ReadOnly = true;
      this.dgvListItems.Size = new System.Drawing.Size(526, 102);
      this.dgvListItems.TabIndex = 1;
      // 
      // ctrlListItems
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvListItems);
      this.Name = "ctrlListItems";
      this.Size = new System.Drawing.Size(662, 167);
      this.Load += new System.EventHandler(this.ctrlListItems_Load);
      this.Resize += new System.EventHandler(this.ctrlListItems_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvListItems;
  }
}
