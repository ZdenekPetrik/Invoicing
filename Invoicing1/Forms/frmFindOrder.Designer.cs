namespace Invoicing.Forms
{
  partial class frmFindOrder
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
      this.lbOrder = new System.Windows.Forms.ListBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbOrder
      // 
      this.lbOrder.FormattingEnabled = true;
      this.lbOrder.Location = new System.Drawing.Point(12, 12);
      this.lbOrder.Name = "lbOrder";
      this.lbOrder.Size = new System.Drawing.Size(399, 342);
      this.lbOrder.TabIndex = 0;
      this.lbOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbOrder_MouseDoubleClick);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(159, 360);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Vyber";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmFindOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 392);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lbOrder);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmFindOrder";
      this.Text = "Výběr aktivní zakázky";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.frmFindOrder_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbOrder;
    private System.Windows.Forms.Button button1;
  }
}