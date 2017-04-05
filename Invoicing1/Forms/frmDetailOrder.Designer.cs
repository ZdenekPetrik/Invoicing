namespace Invoicing.Forms
{
  partial class frmDetailOrder
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
      this.label6 = new System.Windows.Forms.Label();
      this.txtScanPrefix = new System.Windows.Forms.TextBox();
      this.btnScanPDF = new System.Windows.Forms.Button();
      this.txtObdobi = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtNrSCAN = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtScanPath = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtZadavatel = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtCreateDate = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.ctrlShowOrder1 = new Invoicing.Controls.ctrlShowOrder();
      this.label9 = new System.Windows.Forms.Label();
      this.lblId = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(256, 154);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Prefix";
      // 
      // txtScanPrefix
      // 
      this.txtScanPrefix.Enabled = false;
      this.txtScanPrefix.Location = new System.Drawing.Point(318, 153);
      this.txtScanPrefix.Name = "txtScanPrefix";
      this.txtScanPrefix.Size = new System.Drawing.Size(236, 20);
      this.txtScanPrefix.TabIndex = 15;
      // 
      // btnScanPDF
      // 
      this.btnScanPDF.Location = new System.Drawing.Point(777, 232);
      this.btnScanPDF.Name = "btnScanPDF";
      this.btnScanPDF.Size = new System.Drawing.Size(95, 23);
      this.btnScanPDF.TabIndex = 8;
      this.btnScanPDF.Text = "Check PDF";
      this.btnScanPDF.UseVisualStyleBackColor = true;
      this.btnScanPDF.Click += new System.EventHandler(this.btnScanPDF_Click);
      // 
      // txtObdobi
      // 
      this.txtObdobi.Enabled = false;
      this.txtObdobi.Location = new System.Drawing.Point(812, 77);
      this.txtObdobi.Name = "txtObdobi";
      this.txtObdobi.Size = new System.Drawing.Size(56, 20);
      this.txtObdobi.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(769, 82);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(43, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "Období";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(513, 271);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label7
      // 
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label7.Location = new System.Drawing.Point(13, 210);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(1122, 2);
      this.label7.TabIndex = 12;
      this.label7.Text = "lblLine";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(250, 182);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Počet Scan";
      // 
      // txtNrSCAN
      // 
      this.txtNrSCAN.Enabled = false;
      this.txtNrSCAN.Location = new System.Drawing.Point(319, 179);
      this.txtNrSCAN.Name = "txtNrSCAN";
      this.txtNrSCAN.Size = new System.Drawing.Size(85, 20);
      this.txtNrSCAN.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(256, 129);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Scan PDF";
      // 
      // txtScanPath
      // 
      this.txtScanPath.Enabled = false;
      this.txtScanPath.Location = new System.Drawing.Point(318, 128);
      this.txtScanPath.Name = "txtScanPath";
      this.txtScanPath.Size = new System.Drawing.Size(554, 20);
      this.txtScanPath.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(256, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Zadavatel";
      // 
      // txtZadavatel
      // 
      this.txtZadavatel.Enabled = false;
      this.txtZadavatel.Location = new System.Drawing.Point(318, 102);
      this.txtZadavatel.Name = "txtZadavatel";
      this.txtZadavatel.Size = new System.Drawing.Size(554, 20);
      this.txtZadavatel.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(623, 182);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(129, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Datum vytvoření zakázky";
      // 
      // txtCreateDate
      // 
      this.txtCreateDate.Enabled = false;
      this.txtCreateDate.Location = new System.Drawing.Point(758, 179);
      this.txtCreateDate.Name = "txtCreateDate";
      this.txtCreateDate.Size = new System.Drawing.Size(114, 20);
      this.txtCreateDate.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(256, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // txtName
      // 
      this.txtName.Enabled = false;
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtName.Location = new System.Drawing.Point(318, 76);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(236, 22);
      this.txtName.TabIndex = 0;
      // 
      // ctrlShowOrder1
      // 
      this.ctrlShowOrder1.Location = new System.Drawing.Point(13, 13);
      this.ctrlShowOrder1.Name = "ctrlShowOrder1";
      this.ctrlShowOrder1.Size = new System.Drawing.Size(1102, 34);
      this.ctrlShowOrder1.TabIndex = 17;
      // 
      // label9
      // 
      this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label9.Location = new System.Drawing.Point(12, 50);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(1122, 2);
      this.label9.TabIndex = 18;
      this.label9.Text = "lblLine";
      // 
      // lblId
      // 
      this.lblId.AutoSize = true;
      this.lblId.Location = new System.Drawing.Point(1052, 186);
      this.lblId.Name = "lblId";
      this.lblId.Size = new System.Drawing.Size(28, 13);
      this.lblId.TabIndex = 19;
      this.lblId.Text = "lblID";
      // 
      // frmDetailOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1138, 306);
      this.Controls.Add(this.lblId);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.ctrlShowOrder1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtScanPrefix);
      this.Controls.Add(this.btnScanPDF);
      this.Controls.Add(this.txtObdobi);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtNrSCAN);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtScanPath);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtZadavatel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtCreateDate);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.Name = "frmDetailOrder";
      this.Text = " ";
      this.Load += new System.EventHandler(this.frmDetailOrder_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCreateDate;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtZadavatel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtScanPath;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNrSCAN;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtObdobi;
    private System.Windows.Forms.Button btnScanPDF;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtScanPrefix;
    private Controls.ctrlShowOrder ctrlShowOrder1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblId;
  }
}