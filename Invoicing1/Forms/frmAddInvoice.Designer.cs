namespace Invoicing.Forms
{
  partial class frmAddInvoice
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
      this.txtPDFScan = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.dtDUZP = new System.Windows.Forms.DateTimePicker();
      this.txtPriceFull = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtNrItems = new System.Windows.Forms.TextBox();
      this.txtHisNumber = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnDodavatelAdd = new System.Windows.Forms.Button();
      this.txtFirmInfo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnShoPDF = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.cmbAutocompleteFirm = new System.Windows.Forms.ComboBox();
      this.lblPoradiDD = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtPDFScan
      // 
      this.txtPDFScan.Location = new System.Drawing.Point(170, 8);
      this.txtPDFScan.Name = "txtPDFScan";
      this.txtPDFScan.Size = new System.Drawing.Size(86, 20);
      this.txtPDFScan.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 11);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(148, 13);
      this.label6.TabIndex = 21;
      this.label6.Text = "PDFScan (multi odděl čárkou)";
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnSave.Location = new System.Drawing.Point(569, 229);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(158, 23);
      this.btnSave.TabIndex = 8;
      this.btnSave.Text = "Vytvoř novou fakturu";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dtDUZP
      // 
      this.dtDUZP.CustomFormat = "dd. MM. yyyy";
      this.dtDUZP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtDUZP.Location = new System.Drawing.Point(170, 137);
      this.dtDUZP.Name = "dtDUZP";
      this.dtDUZP.Size = new System.Drawing.Size(125, 20);
      this.dtDUZP.TabIndex = 9;
      // 
      // txtPriceFull
      // 
      this.txtPriceFull.Location = new System.Drawing.Point(170, 169);
      this.txtPriceFull.Name = "txtPriceFull";
      this.txtPriceFull.Size = new System.Drawing.Size(86, 20);
      this.txtPriceFull.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 143);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(37, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "DUZP";
      // 
      // txtNrItems
      // 
      this.txtNrItems.Location = new System.Drawing.Point(170, 201);
      this.txtNrItems.Name = "txtNrItems";
      this.txtNrItems.Size = new System.Drawing.Size(86, 20);
      this.txtNrItems.TabIndex = 6;
      // 
      // txtHisNumber
      // 
      this.txtHisNumber.Location = new System.Drawing.Point(170, 105);
      this.txtHisNumber.Name = "txtHisNumber";
      this.txtHisNumber.Size = new System.Drawing.Size(125, 20);
      this.txtHisNumber.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 206);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Počet položek";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(7, 172);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Cena bez DPH";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(7, 108);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Číslo faktury Dodavatele";
      // 
      // btnDodavatelAdd
      // 
      this.btnDodavatelAdd.Location = new System.Drawing.Point(415, 38);
      this.btnDodavatelAdd.Name = "btnDodavatelAdd";
      this.btnDodavatelAdd.Size = new System.Drawing.Size(39, 23);
      this.btnDodavatelAdd.TabIndex = 3;
      this.btnDodavatelAdd.Text = "...";
      this.btnDodavatelAdd.UseVisualStyleBackColor = true;
      this.btnDodavatelAdd.Click += new System.EventHandler(this.btnDodavatelAdd_Click);
      // 
      // txtFirmInfo
      // 
      this.txtFirmInfo.Location = new System.Drawing.Point(7, 73);
      this.txtFirmInfo.Name = "txtFirmInfo";
      this.txtFirmInfo.Size = new System.Drawing.Size(720, 20);
      this.txtFirmInfo.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Dodavatel";
      // 
      // btnShoPDF
      // 
      this.btnShoPDF.Image = global::Invoicing.Properties.Resources.Adobe_PDF_file_icon_24x24;
      this.btnShoPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnShoPDF.Location = new System.Drawing.Point(349, 5);
      this.btnShoPDF.Name = "btnShoPDF";
      this.btnShoPDF.Size = new System.Drawing.Size(105, 29);
      this.btnShoPDF.TabIndex = 22;
      this.btnShoPDF.Text = "Show PDF";
      this.btnShoPDF.UseVisualStyleBackColor = true;
      this.btnShoPDF.Click += new System.EventHandler(this.btnShoPDF_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnEdit.Location = new System.Drawing.Point(652, 201);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 23;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnDelete.Location = new System.Drawing.Point(652, 171);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 24;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // cmbAutocompleteFirm
      // 
      this.cmbAutocompleteFirm.FormattingEnabled = true;
      this.cmbAutocompleteFirm.Location = new System.Drawing.Point(170, 40);
      this.cmbAutocompleteFirm.Name = "cmbAutocompleteFirm";
      this.cmbAutocompleteFirm.Size = new System.Drawing.Size(223, 21);
      this.cmbAutocompleteFirm.TabIndex = 25;
      this.cmbAutocompleteFirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAutocompleteFirm_KeyDown);
      // 
      // lblPoradiDD
      // 
      this.lblPoradiDD.AutoSize = true;
      this.lblPoradiDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblPoradiDD.Location = new System.Drawing.Point(603, 17);
      this.lblPoradiDD.Name = "lblPoradiDD";
      this.lblPoradiDD.Size = new System.Drawing.Size(124, 42);
      this.lblPoradiDD.TabIndex = 26;
      this.lblPoradiDD.Text = "label2";
      this.lblPoradiDD.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // frmAddInvoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(742, 263);
      this.Controls.Add(this.lblPoradiDD);
      this.Controls.Add(this.cmbAutocompleteFirm);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnShoPDF);
      this.Controls.Add(this.txtPDFScan);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.dtDUZP);
      this.Controls.Add(this.txtPriceFull);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtNrItems);
      this.Controls.Add(this.txtHisNumber);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnDodavatelAdd);
      this.Controls.Add(this.txtFirmInfo);
      this.Controls.Add(this.label1);
      this.Name = "frmAddInvoice";
      this.Text = "Faktura (Dodací list) - ADD";
      this.Load += new System.EventHandler(this.frmAddInvoice_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFirmInfo;
    private System.Windows.Forms.Button btnDodavatelAdd;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtHisNumber;
    private System.Windows.Forms.TextBox txtNrItems;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtPriceFull;
    private System.Windows.Forms.DateTimePicker dtDUZP;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtPDFScan;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnShoPDF;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ComboBox cmbAutocompleteFirm;
    private System.Windows.Forms.Label lblPoradiDD;
  }
}