namespace Invoicing.Forms
{
  partial class frmAddOrder
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtZadavatel = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtScanPath = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtNrSCAN = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.btnScanPDF = new System.Windows.Forms.Button();
      this.btnDirectoryPDF = new System.Windows.Forms.Button();
      this.btnZadavatel = new System.Windows.Forms.Button();
      this.dtOrderSeason = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPrefixFilePDF = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtName.Location = new System.Drawing.Point(105, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(307, 22);
      this.txtName.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Název zakázky";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Zadavatel";
      // 
      // txtZadavatel
      // 
      this.txtZadavatel.Enabled = false;
      this.txtZadavatel.Location = new System.Drawing.Point(105, 44);
      this.txtZadavatel.Name = "txtZadavatel";
      this.txtZadavatel.Size = new System.Drawing.Size(474, 20);
      this.txtZadavatel.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 77);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Cesta Scan PDF";
      // 
      // txtScanPath
      // 
      this.txtScanPath.Location = new System.Drawing.Point(105, 74);
      this.txtScanPath.Name = "txtScanPath";
      this.txtScanPath.Size = new System.Drawing.Size(474, 20);
      this.txtScanPath.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 137);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(87, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Počet Scan PDF";
      // 
      // txtNrSCAN
      // 
      this.txtNrSCAN.Location = new System.Drawing.Point(105, 134);
      this.txtNrSCAN.Name = "txtNrSCAN";
      this.txtNrSCAN.Size = new System.Drawing.Size(43, 20);
      this.txtNrSCAN.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label7.Location = new System.Drawing.Point(9, 160);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(616, 2);
      this.label7.TabIndex = 12;
      this.label7.Text = "lblLine";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(264, 178);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(109, 23);
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK -  Vytvořit";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(474, 17);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(43, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "Období";
      // 
      // btnScanPDF
      // 
      this.btnScanPDF.Location = new System.Drawing.Point(491, 134);
      this.btnScanPDF.Name = "btnScanPDF";
      this.btnScanPDF.Size = new System.Drawing.Size(138, 23);
      this.btnScanPDF.TabIndex = 8;
      this.btnScanPDF.Text = "Zkotroluji PDF Cestu";
      this.btnScanPDF.UseVisualStyleBackColor = true;
      this.btnScanPDF.Click += new System.EventHandler(this.btnScanPDF_Click);
      // 
      // btnDirectoryPDF
      // 
      this.btnDirectoryPDF.Location = new System.Drawing.Point(589, 73);
      this.btnDirectoryPDF.Name = "btnDirectoryPDF";
      this.btnDirectoryPDF.Size = new System.Drawing.Size(40, 21);
      this.btnDirectoryPDF.TabIndex = 15;
      this.btnDirectoryPDF.Text = "...";
      this.btnDirectoryPDF.UseVisualStyleBackColor = true;
      this.btnDirectoryPDF.Click += new System.EventHandler(this.btnDirectoryPDF_Click);
      // 
      // btnZadavatel
      // 
      this.btnZadavatel.Location = new System.Drawing.Point(589, 44);
      this.btnZadavatel.Name = "btnZadavatel";
      this.btnZadavatel.Size = new System.Drawing.Size(40, 21);
      this.btnZadavatel.TabIndex = 16;
      this.btnZadavatel.Text = "...";
      this.btnZadavatel.UseVisualStyleBackColor = true;
      this.btnZadavatel.Click += new System.EventHandler(this.btnZadavatel_Click);
      // 
      // dtOrderSeason
      // 
      this.dtOrderSeason.CustomFormat = "MM. yyyy";
      this.dtOrderSeason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtOrderSeason.Location = new System.Drawing.Point(537, 14);
      this.dtOrderSeason.Name = "dtOrderSeason";
      this.dtOrderSeason.Size = new System.Drawing.Size(92, 20);
      this.dtOrderSeason.TabIndex = 17;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "Prefix File PDF";
      // 
      // txtPrefixFilePDF
      // 
      this.txtPrefixFilePDF.Location = new System.Drawing.Point(105, 104);
      this.txtPrefixFilePDF.Name = "txtPrefixFilePDF";
      this.txtPrefixFilePDF.Size = new System.Drawing.Size(161, 20);
      this.txtPrefixFilePDF.TabIndex = 18;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(266, 111);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(97, 13);
      this.label6.TabIndex = 20;
      this.label6.Text = "001,002,003,...999";
      // 
      // frmAddOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 213);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPrefixFilePDF);
      this.Controls.Add(this.dtOrderSeason);
      this.Controls.Add(this.btnZadavatel);
      this.Controls.Add(this.btnDirectoryPDF);
      this.Controls.Add(this.btnScanPDF);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtNrSCAN);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtScanPath);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtZadavatel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddOrder";
      this.Text = "Vytvoření zakázky";
      this.Load += new System.EventHandler(this.frmDetailOrder_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtZadavatel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtScanPath;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNrSCAN;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnScanPDF;
    private System.Windows.Forms.Button btnDirectoryPDF;
    private System.Windows.Forms.Button btnZadavatel;
    private System.Windows.Forms.DateTimePicker dtOrderSeason;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPrefixFilePDF;
    private System.Windows.Forms.Label label6;
  }
}