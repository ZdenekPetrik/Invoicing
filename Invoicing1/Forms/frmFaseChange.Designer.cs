namespace Invoicing.Forms
{
  partial class frmFaseChange
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
      this.ctrlShowOrder1 = new Invoicing.Controls.ctrlShowOrder();
      this.panelFaze23 = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTest = new System.Windows.Forms.Button();
      this.btnFaze = new System.Windows.Forms.Button();
      this.panelFaze12 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.panelFaze34 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.txtProtokol = new System.Windows.Forms.TextBox();
      this.panelFaze23.SuspendLayout();
      this.panelFaze12.SuspendLayout();
      this.panelFaze34.SuspendLayout();
      this.SuspendLayout();
      // 
      // ctrlShowOrder1
      // 
      this.ctrlShowOrder1.Location = new System.Drawing.Point(7, 12);
      this.ctrlShowOrder1.Name = "ctrlShowOrder1";
      this.ctrlShowOrder1.Size = new System.Drawing.Size(1102, 34);
      this.ctrlShowOrder1.TabIndex = 0;
      // 
      // panelFaze23
      // 
      this.panelFaze23.Controls.Add(this.lblTitle);
      this.panelFaze23.Controls.Add(this.label4);
      this.panelFaze23.Controls.Add(this.label3);
      this.panelFaze23.Controls.Add(this.label2);
      this.panelFaze23.Controls.Add(this.label1);
      this.panelFaze23.Location = new System.Drawing.Point(12, 71);
      this.panelFaze23.Name = "panelFaze23";
      this.panelFaze23.Size = new System.Drawing.Size(458, 143);
      this.panelFaze23.TabIndex = 1;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblTitle.Location = new System.Drawing.Point(15, 18);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(330, 16);
      this.lblTitle.TabIndex = 4;
      this.lblTitle.Text = "Přesun z Fáze 2 - Hlavičky do Fáze 3 - Položky";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 114);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(300, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "4.  Faktura musí mít alespoň jednu položku a nenulovou cenu";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(353, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "3.  Každé naskenované PDF musí být použito na Faktuře (Dodacím listu)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 67);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(280, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "2.  Naskenované PDF musí tvořit souvislou řadu (1,2,...n)";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(355, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "1.  Naskenované PDF musí existovat a v adresáři nesmí být žádné navíc";
      // 
      // btnTest
      // 
      this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnTest.Location = new System.Drawing.Point(12, 241);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(133, 23);
      this.btnTest.TabIndex = 2;
      this.btnTest.Text = "Test + Protokol";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // btnFaze
      // 
      this.btnFaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnFaze.Location = new System.Drawing.Point(352, 241);
      this.btnFaze.Name = "btnFaze";
      this.btnFaze.Size = new System.Drawing.Size(118, 23);
      this.btnFaze.TabIndex = 3;
      this.btnFaze.Text = "Převeď ";
      this.btnFaze.UseVisualStyleBackColor = true;
      // 
      // panelFaze12
      // 
      this.panelFaze12.Controls.Add(this.label5);
      this.panelFaze12.Controls.Add(this.label8);
      this.panelFaze12.Controls.Add(this.label9);
      this.panelFaze12.Location = new System.Drawing.Point(522, 71);
      this.panelFaze12.Name = "panelFaze12";
      this.panelFaze12.Size = new System.Drawing.Size(458, 143);
      this.panelFaze12.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label5.Location = new System.Drawing.Point(15, 18);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(336, 16);
      this.label5.TabIndex = 4;
      this.label5.Text = "Přesun z \"Fáze 1 - Nová\" do \"Fáze 2 - Hlavičky\"";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(15, 67);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(280, 13);
      this.label8.TabIndex = 1;
      this.label8.Text = "2.  Naskenované PDF musí tvořit souvislou řadu (1,2,...n)";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(14, 44);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(355, 13);
      this.label9.TabIndex = 0;
      this.label9.Text = "1.  Naskenované PDF musí existovat a v adresáři nesmí být žádné navíc";
      // 
      // panelFaze34
      // 
      this.panelFaze34.Controls.Add(this.label6);
      this.panelFaze34.Controls.Add(this.label7);
      this.panelFaze34.Controls.Add(this.label10);
      this.panelFaze34.Location = new System.Drawing.Point(522, 226);
      this.panelFaze34.Name = "panelFaze34";
      this.panelFaze34.Size = new System.Drawing.Size(458, 143);
      this.panelFaze34.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label6.Location = new System.Drawing.Point(15, 18);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(356, 16);
      this.label6.TabIndex = 4;
      this.label6.Text = "Přesun z \"Fáze 3 - Položky\" do \"Fáze 4 - Párování\"";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(15, 67);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(280, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "2.  Naskenované PDF musí tvořit souvislou řadu (1,2,...n)";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(14, 44);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(355, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "1.  Naskenované PDF musí existovat a v adresáři nesmí být žádné navíc";
      // 
      // txtProtokol
      // 
      this.txtProtokol.Location = new System.Drawing.Point(522, 45);
      this.txtProtokol.Multiline = true;
      this.txtProtokol.Name = "txtProtokol";
      this.txtProtokol.Size = new System.Drawing.Size(572, 20);
      this.txtProtokol.TabIndex = 7;
      // 
      // frmFaseChange
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1129, 381);
      this.Controls.Add(this.txtProtokol);
      this.Controls.Add(this.panelFaze34);
      this.Controls.Add(this.panelFaze12);
      this.Controls.Add(this.btnFaze);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.panelFaze23);
      this.Controls.Add(this.ctrlShowOrder1);
      this.Name = "frmFaseChange";
      this.Text = "Změna fáze plnění zakázky";
      this.Load += new System.EventHandler(this.frmFaseChange_Load);
      this.panelFaze23.ResumeLayout(false);
      this.panelFaze23.PerformLayout();
      this.panelFaze12.ResumeLayout(false);
      this.panelFaze12.PerformLayout();
      this.panelFaze34.ResumeLayout(false);
      this.panelFaze34.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Controls.ctrlShowOrder ctrlShowOrder1;
    private System.Windows.Forms.Panel panelFaze23;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.Button btnFaze;
    private System.Windows.Forms.Panel panelFaze12;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Panel panelFaze34;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtProtokol;
  }
}