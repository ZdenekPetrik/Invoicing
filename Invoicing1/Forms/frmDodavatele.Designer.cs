namespace Invoicing.Forms
{
  partial class frmDodavatele
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
      this.txtDIC = new System.Windows.Forms.TextBox();
      this.txtIco = new System.Windows.Forms.TextBox();
      this.txtZipCode = new System.Windows.Forms.TextBox();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.txtAdress = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.btnSaveDB = new System.Windows.Forms.Button();
      this.btnSearchARES = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lbDodavatele = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // txtDIC
      // 
      this.txtDIC.Location = new System.Drawing.Point(289, 438);
      this.txtDIC.Name = "txtDIC";
      this.txtDIC.Size = new System.Drawing.Size(142, 20);
      this.txtDIC.TabIndex = 3;
      // 
      // txtIco
      // 
      this.txtIco.Location = new System.Drawing.Point(78, 440);
      this.txtIco.Name = "txtIco";
      this.txtIco.Size = new System.Drawing.Size(97, 20);
      this.txtIco.TabIndex = 2;
      // 
      // txtZipCode
      // 
      this.txtZipCode.Location = new System.Drawing.Point(78, 495);
      this.txtZipCode.Name = "txtZipCode";
      this.txtZipCode.Size = new System.Drawing.Size(59, 20);
      this.txtZipCode.TabIndex = 5;
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(225, 498);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(206, 20);
      this.txtCity.TabIndex = 6;
      // 
      // txtAdress
      // 
      this.txtAdress.Location = new System.Drawing.Point(78, 469);
      this.txtAdress.Name = "txtAdress";
      this.txtAdress.Size = new System.Drawing.Size(353, 20);
      this.txtAdress.TabIndex = 4;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(78, 412);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(353, 20);
      this.txtName.TabIndex = 1;
      // 
      // btnOK
      // 
      this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnOK.Location = new System.Drawing.Point(658, 495);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(115, 23);
      this.btnOK.TabIndex = 10;
      this.btnOK.Text = "OK Vybráno";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(480, 415);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(97, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Hledej DB";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // btnSaveDB
      // 
      this.btnSaveDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnSaveDB.Location = new System.Drawing.Point(480, 493);
      this.btnSaveDB.Name = "btnSaveDB";
      this.btnSaveDB.Size = new System.Drawing.Size(97, 23);
      this.btnSaveDB.TabIndex = 9;
      this.btnSaveDB.Text = "Uložit DB";
      this.btnSaveDB.UseVisualStyleBackColor = true;
      this.btnSaveDB.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnSearchARES
      // 
      this.btnSearchARES.Location = new System.Drawing.Point(480, 450);
      this.btnSearchARES.Name = "btnSearchARES";
      this.btnSearchARES.Size = new System.Drawing.Size(97, 23);
      this.btnSearchARES.TabIndex = 8;
      this.btnSearchARES.Text = "Hledej ARES";
      this.btnSearchARES.UseVisualStyleBackColor = true;
      this.btnSearchARES.Click += new System.EventHandler(this.btnSearchARES_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(180, 500);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(39, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "Město:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(17, 500);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "PSČ:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(17, 472);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(43, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Adresa:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 415);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Název:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(245, 443);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "DIČ:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 443);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "IČ:";
      // 
      // lbDodavatele
      // 
      this.lbDodavatele.FormattingEnabled = true;
      this.lbDodavatele.Location = new System.Drawing.Point(12, 12);
      this.lbDodavatele.Name = "lbDodavatele";
      this.lbDodavatele.Size = new System.Drawing.Size(739, 368);
      this.lbDodavatele.TabIndex = 0;
      this.lbDodavatele.SelectedIndexChanged += new System.EventHandler(this.lbDodavatele_SelectedIndexChanged);
      this.lbDodavatele.DoubleClick += new System.EventHandler(this.lbDodavatele_DoubleClick);
      // 
      // frmDodavatele
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(795, 529);
      this.Controls.Add(this.txtDIC);
      this.Controls.Add(this.txtIco);
      this.Controls.Add(this.txtZipCode);
      this.Controls.Add(this.txtCity);
      this.Controls.Add(this.txtAdress);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnSaveDB);
      this.Controls.Add(this.btnSearchARES);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbDodavatele);
      this.Name = "frmDodavatele";
      this.Text = "frmDodavatele";
      this.Load += new System.EventHandler(this.frmDodavatele_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbDodavatele;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnSearchARES;
    private System.Windows.Forms.Button btnSaveDB;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAdress;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtZipCode;
    private System.Windows.Forms.TextBox txtIco;
    private System.Windows.Forms.TextBox txtDIC;
  }
}