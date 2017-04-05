namespace Invoicing.Forms
{
  partial class frmProductDetail
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
      this.components = new System.ComponentModel.Container();
      this.dgvProduktPrice = new Invoicing.Component.DataGridViewExt(this.components);
      this.dgvParovani = new Invoicing.Component.DataGridViewExt(this.components);
      this.lblProductName = new System.Windows.Forms.Label();
      this.lblProductDruh = new System.Windows.Forms.Label();
      this.lblProductKomodita = new System.Windows.Forms.Label();
      this.lblProductPodkomodita = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblPriznak = new System.Windows.Forms.Label();
      this.lblMark = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lblQuantity = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblUnit = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.dtOrderSeason = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduktPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvParovani)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvProduktPrice
      // 
      this.dgvProduktPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProduktPrice.Location = new System.Drawing.Point(22, 90);
      this.dgvProduktPrice.Name = "dgvProduktPrice";
      this.dgvProduktPrice.Size = new System.Drawing.Size(797, 354);
      this.dgvProduktPrice.TabIndex = 0;
      this.dgvProduktPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduktPrice_CellContentClick);
      // 
      // dgvParovani
      // 
      this.dgvParovani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvParovani.Location = new System.Drawing.Point(22, 458);
      this.dgvParovani.Name = "dgvParovani";
      this.dgvParovani.Size = new System.Drawing.Size(240, 150);
      this.dgvParovani.TabIndex = 1;
      // 
      // lblProductName
      // 
      this.lblProductName.AutoSize = true;
      this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblProductName.Location = new System.Drawing.Point(22, 13);
      this.lblProductName.Name = "lblProductName";
      this.lblProductName.Size = new System.Drawing.Size(135, 20);
      this.lblProductName.TabIndex = 2;
      this.lblProductName.Text = "lblProductName";
      // 
      // lblProductDruh
      // 
      this.lblProductDruh.AutoSize = true;
      this.lblProductDruh.Location = new System.Drawing.Point(23, 39);
      this.lblProductDruh.Name = "lblProductDruh";
      this.lblProductDruh.Size = new System.Drawing.Size(77, 13);
      this.lblProductDruh.TabIndex = 3;
      this.lblProductDruh.Text = "lblProductDruh";
      // 
      // lblProductKomodita
      // 
      this.lblProductKomodita.AutoSize = true;
      this.lblProductKomodita.Location = new System.Drawing.Point(52, 52);
      this.lblProductKomodita.Name = "lblProductKomodita";
      this.lblProductKomodita.Size = new System.Drawing.Size(98, 13);
      this.lblProductKomodita.TabIndex = 4;
      this.lblProductKomodita.Text = "lblProductKomodita";
      // 
      // lblProductPodkomodita
      // 
      this.lblProductPodkomodita.AutoSize = true;
      this.lblProductPodkomodita.Location = new System.Drawing.Point(68, 65);
      this.lblProductPodkomodita.Name = "lblProductPodkomodita";
      this.lblProductPodkomodita.Size = new System.Drawing.Size(116, 13);
      this.lblProductPodkomodita.TabIndex = 5;
      this.lblProductPodkomodita.Text = "lblProductPodkomodita";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(342, 34);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Příznak:";
      // 
      // lblPriznak
      // 
      this.lblPriznak.AutoSize = true;
      this.lblPriznak.Location = new System.Drawing.Point(396, 34);
      this.lblPriznak.Name = "lblPriznak";
      this.lblPriznak.Size = new System.Drawing.Size(48, 13);
      this.lblPriznak.TabIndex = 8;
      this.lblPriznak.Text = "Příznak:";
      // 
      // lblMark
      // 
      this.lblMark.AutoSize = true;
      this.lblMark.Location = new System.Drawing.Point(396, 52);
      this.lblMark.Name = "lblMark";
      this.lblMark.Size = new System.Drawing.Size(48, 13);
      this.lblMark.TabIndex = 10;
      this.lblMark.Text = "Příznak:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(342, 52);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(47, 13);
      this.label8.TabIndex = 9;
      this.label8.Text = "Značka:";
      // 
      // lblQuantity
      // 
      this.lblQuantity.AutoSize = true;
      this.lblQuantity.Location = new System.Drawing.Point(649, 39);
      this.lblQuantity.Name = "lblQuantity";
      this.lblQuantity.Size = new System.Drawing.Size(54, 13);
      this.lblQuantity.TabIndex = 12;
      this.lblQuantity.Text = "Množství:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(595, 39);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(54, 13);
      this.label9.TabIndex = 11;
      this.label9.Text = "Množství:";
      // 
      // lblUnit
      // 
      this.lblUnit.AutoSize = true;
      this.lblUnit.Location = new System.Drawing.Point(649, 65);
      this.lblUnit.Name = "lblUnit";
      this.lblUnit.Size = new System.Drawing.Size(54, 13);
      this.lblUnit.TabIndex = 14;
      this.lblUnit.Text = "Množství:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(595, 65);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(54, 13);
      this.label10.TabIndex = 13;
      this.label10.Text = "Jednotka:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(684, 7);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(37, 13);
      this.label7.TabIndex = 15;
      this.label7.Text = "Měsíc";
      // 
      // dtOrderSeason
      // 
      this.dtOrderSeason.CustomFormat = "MM. yyyy";
      this.dtOrderSeason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtOrderSeason.Location = new System.Drawing.Point(727, 3);
      this.dtOrderSeason.Name = "dtOrderSeason";
      this.dtOrderSeason.Size = new System.Drawing.Size(92, 20);
      this.dtOrderSeason.TabIndex = 19;
      // 
      // frmProductDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 609);
      this.Controls.Add(this.dtOrderSeason);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblUnit);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.lblQuantity);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.lblMark);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblPriznak);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.lblProductPodkomodita);
      this.Controls.Add(this.lblProductKomodita);
      this.Controls.Add(this.lblProductDruh);
      this.Controls.Add(this.lblProductName);
      this.Controls.Add(this.dgvParovani);
      this.Controls.Add(this.dgvProduktPrice);
      this.Name = "frmProductDetail";
      this.Text = "Produkt - Detail";
      this.Load += new System.EventHandler(this.frmProductDetail_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduktPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvParovani)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Component.DataGridViewExt dgvProduktPrice;
    private Component.DataGridViewExt dgvParovani;
    private System.Windows.Forms.Label lblProductName;
    private System.Windows.Forms.Label lblProductDruh;
    private System.Windows.Forms.Label lblProductKomodita;
    private System.Windows.Forms.Label lblProductPodkomodita;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblPriznak;
    private System.Windows.Forms.Label lblMark;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblUnit;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DateTimePicker dtOrderSeason;
  }
}