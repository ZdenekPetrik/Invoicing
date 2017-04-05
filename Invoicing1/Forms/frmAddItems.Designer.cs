namespace Invoicing.Forms
{
  partial class frmAddItems
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
      this.txtPriceExpected = new System.Windows.Forms.TextBox();
      this.txtPriceDone = new System.Windows.Forms.TextBox();
      this.txtNrItemsDone = new System.Windows.Forms.TextBox();
      this.txtNrItemsExpected = new System.Windows.Forms.TextBox();
      this.lblInvoice = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtPriceExpected
      // 
      this.txtPriceExpected.Enabled = false;
      this.txtPriceExpected.Location = new System.Drawing.Point(620, 13);
      this.txtPriceExpected.Name = "txtPriceExpected";
      this.txtPriceExpected.Size = new System.Drawing.Size(100, 20);
      this.txtPriceExpected.TabIndex = 3;
      // 
      // txtPriceDone
      // 
      this.txtPriceDone.Enabled = false;
      this.txtPriceDone.Location = new System.Drawing.Point(747, 13);
      this.txtPriceDone.Name = "txtPriceDone";
      this.txtPriceDone.Size = new System.Drawing.Size(100, 20);
      this.txtPriceDone.TabIndex = 4;
      this.txtPriceDone.TextChanged += new System.EventHandler(this.txtPriceDone_TextChanged);
      // 
      // txtNrItemsDone
      // 
      this.txtNrItemsDone.Enabled = false;
      this.txtNrItemsDone.Location = new System.Drawing.Point(491, 12);
      this.txtNrItemsDone.Name = "txtNrItemsDone";
      this.txtNrItemsDone.Size = new System.Drawing.Size(29, 20);
      this.txtNrItemsDone.TabIndex = 2;
      this.txtNrItemsDone.TextChanged += new System.EventHandler(this.txtNrItemsDone_TextChanged);
      // 
      // txtNrItemsExpected
      // 
      this.txtNrItemsExpected.Enabled = false;
      this.txtNrItemsExpected.Location = new System.Drawing.Point(443, 12);
      this.txtNrItemsExpected.Name = "txtNrItemsExpected";
      this.txtNrItemsExpected.Size = new System.Drawing.Size(29, 20);
      this.txtNrItemsExpected.TabIndex = 1;
      // 
      // lblInvoice
      // 
      this.lblInvoice.AutoSize = true;
      this.lblInvoice.Location = new System.Drawing.Point(12, 16);
      this.lblInvoice.Name = "lblInvoice";
      this.lblInvoice.Size = new System.Drawing.Size(35, 13);
      this.lblInvoice.TabIndex = 0;
      this.lblInvoice.Text = "label1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(5, 51);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(842, 153);
      this.panel1.TabIndex = 6;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(409, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(30, 13);
      this.label9.TabIndex = 8;
      this.label9.Text = "DPH";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(86, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(17, 13);
      this.label8.TabIndex = 3;
      this.label8.Text = "# ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(671, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(51, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "Jednotka";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(591, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(42, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "Celkem";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(548, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Počet";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(460, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Jednotková cena";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(109, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(77, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Název položky";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "# PDF";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "# DD";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(733, 51);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(94, 13);
      this.label10.TabIndex = 9;
      this.label10.Text = "Celkem (bez DPH)";
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnSave.Location = new System.Drawing.Point(741, 210);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(106, 37);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Uložit";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // frmAddItems
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(859, 259);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblInvoice);
      this.Controls.Add(this.txtNrItemsExpected);
      this.Controls.Add(this.txtNrItemsDone);
      this.Controls.Add(this.txtPriceDone);
      this.Controls.Add(this.txtPriceExpected);
      this.Name = "frmAddItems";
      this.Text = "frmAddItems";
      this.Load += new System.EventHandler(this.frmAddItems_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPriceExpected;
    private System.Windows.Forms.TextBox txtPriceDone;
    private System.Windows.Forms.TextBox txtNrItemsDone;
    private System.Windows.Forms.TextBox txtNrItemsExpected;
    private System.Windows.Forms.Label lblInvoice;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
  }
}