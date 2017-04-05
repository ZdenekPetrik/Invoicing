namespace Invoicing.Controls
{
  partial class ctrlInvoicesList
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgInvoices = new System.Windows.Forms.DataGridView();
      this.lblTest = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).BeginInit();
      this.SuspendLayout();
      // 
      // dgInvoices
      // 
      this.dgInvoices.AllowUserToAddRows = false;
      this.dgInvoices.AllowUserToDeleteRows = false;
      this.dgInvoices.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dgInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgInvoices.Location = new System.Drawing.Point(12, 12);
      this.dgInvoices.Name = "dgInvoices";
      this.dgInvoices.ReadOnly = true;
      this.dgInvoices.Size = new System.Drawing.Size(465, 123);
      this.dgInvoices.TabIndex = 0;
      this.dgInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoices_CellContentClick);
      this.dgInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgInvoices_CellFormatting);
      this.dgInvoices.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgInvoices_ColumnHeaderMouseClick);
      this.dgInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgInvoices_DataBindingComplete);
      this.dgInvoices.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoices_RowEnter);
      this.dgInvoices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgInvoices_MouseClick);
      this.dgInvoices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgInvoices_MouseDoubleClick);
      // 
      // lblTest
      // 
      this.lblTest.AutoSize = true;
      this.lblTest.Location = new System.Drawing.Point(398, 206);
      this.lblTest.Name = "lblTest";
      this.lblTest.Size = new System.Drawing.Size(38, 13);
      this.lblTest.TabIndex = 1;
      this.lblTest.Text = "lblTest";
      // 
      // ctrlInvoicesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblTest);
      this.Controls.Add(this.dgInvoices);
      this.Name = "ctrlInvoicesList";
      this.Size = new System.Drawing.Size(736, 243);
      this.Load += new System.EventHandler(this.ctrlInvoicesList_Load);
      this.Resize += new System.EventHandler(this.ctrlInvoicesList_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgInvoices;
    private System.Windows.Forms.Label lblTest;
  }
}
