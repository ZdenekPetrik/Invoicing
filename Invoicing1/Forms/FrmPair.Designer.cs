namespace Invoicing.Forms
{
  partial class FrmPair
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnPorovnej = new System.Windows.Forms.Button();
      this.txtSearchString = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.gvPair = new Invoicing.Component.DataGridViewExt(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnPairDetail = new System.Windows.Forms.Button();
      this.lblPairStatus = new System.Windows.Forms.Label();
      this.lblPairRow = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnProductDetail = new System.Windows.Forms.Button();
      this.lblAvg5 = new System.Windows.Forms.Label();
      this.lblAvg4 = new System.Windows.Forms.Label();
      this.lblAvg3 = new System.Windows.Forms.Label();
      this.lblAvg2 = new System.Windows.Forms.Label();
      this.lblAvg1 = new System.Windows.Forms.Label();
      this.lblMin5 = new System.Windows.Forms.Label();
      this.lblMin4 = new System.Windows.Forms.Label();
      this.lblMin3 = new System.Windows.Forms.Label();
      this.lblMin2 = new System.Windows.Forms.Label();
      this.lblMin1 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.gvProdukty = new Invoicing.Component.DataGridViewExt(this.components);
      this.cmbPairType = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.gvPair)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvProdukty)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(186, 275);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(140, 23);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Zruš Párování";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnPorovnej
      // 
      this.btnPorovnej.Location = new System.Drawing.Point(16, 275);
      this.btnPorovnej.Name = "btnPorovnej";
      this.btnPorovnej.Size = new System.Drawing.Size(151, 23);
      this.btnPorovnej.TabIndex = 4;
      this.btnPorovnej.Text = "Páruj";
      this.btnPorovnej.UseVisualStyleBackColor = true;
      this.btnPorovnej.Click += new System.EventHandler(this.btnPorovnej_Click);
      // 
      // txtSearchString
      // 
      this.txtSearchString.Location = new System.Drawing.Point(3, 12);
      this.txtSearchString.Name = "txtSearchString";
      this.txtSearchString.Size = new System.Drawing.Size(164, 20);
      this.txtSearchString.TabIndex = 2;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(208, 10);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(118, 23);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "Hledej";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // gvPair
      // 
      this.gvPair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvPair.Location = new System.Drawing.Point(10, 0);
      this.gvPair.Name = "gvPair";
      this.gvPair.Size = new System.Drawing.Size(403, 100);
      this.gvPair.TabIndex = 0;
      this.gvPair.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPair_CellClick);
      this.gvPair.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPair_CellContentClick);
      this.gvPair.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvPair_CellFormatting);
      this.gvPair.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvPair_ColumnHeaderMouseClick);
      this.gvPair.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvPair_DataBindingComplete);
      this.gvPair.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPair_RowEnter);
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Location = new System.Drawing.Point(94, 12);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.btnPairDetail);
      this.splitContainer1.Panel1.Controls.Add(this.lblPairStatus);
      this.splitContainer1.Panel1.Controls.Add(this.lblPairRow);
      this.splitContainer1.Panel1.Controls.Add(this.gvPair);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panel1);
      this.splitContainer1.Panel2.Controls.Add(this.gvProdukty);
      this.splitContainer1.Panel2.Controls.Add(this.cmbPairType);
      this.splitContainer1.Panel2.Controls.Add(this.txtSearchString);
      this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
      this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
      this.splitContainer1.Panel2.Controls.Add(this.btnPorovnej);
      this.splitContainer1.Size = new System.Drawing.Size(949, 517);
      this.splitContainer1.SplitterDistance = 530;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 6;
      this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
      // 
      // btnPairDetail
      // 
      this.btnPairDetail.Location = new System.Drawing.Point(402, 488);
      this.btnPairDetail.Name = "btnPairDetail";
      this.btnPairDetail.Size = new System.Drawing.Size(121, 22);
      this.btnPairDetail.TabIndex = 17;
      this.btnPairDetail.Text = "Detail Párování";
      this.btnPairDetail.UseVisualStyleBackColor = true;
      this.btnPairDetail.Click += new System.EventHandler(this.btnPairDetail_Click);
      // 
      // lblPairStatus
      // 
      this.lblPairStatus.AutoSize = true;
      this.lblPairStatus.Location = new System.Drawing.Point(86, 488);
      this.lblPairStatus.Name = "lblPairStatus";
      this.lblPairStatus.Size = new System.Drawing.Size(35, 13);
      this.lblPairStatus.TabIndex = 2;
      this.lblPairStatus.Text = "label8";
      // 
      // lblPairRow
      // 
      this.lblPairRow.AutoSize = true;
      this.lblPairRow.Location = new System.Drawing.Point(3, 488);
      this.lblPairRow.Name = "lblPairRow";
      this.lblPairRow.Size = new System.Drawing.Size(35, 13);
      this.lblPairRow.TabIndex = 1;
      this.lblPairRow.Text = "label8";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Controls.Add(this.btnProductDetail);
      this.panel1.Controls.Add(this.lblAvg5);
      this.panel1.Controls.Add(this.lblAvg4);
      this.panel1.Controls.Add(this.lblAvg3);
      this.panel1.Controls.Add(this.lblAvg2);
      this.panel1.Controls.Add(this.lblAvg1);
      this.panel1.Controls.Add(this.lblMin5);
      this.panel1.Controls.Add(this.lblMin4);
      this.panel1.Controls.Add(this.lblMin3);
      this.panel1.Controls.Add(this.lblMin2);
      this.panel1.Controls.Add(this.lblMin1);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(3, 320);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(459, 104);
      this.panel1.TabIndex = 8;
      // 
      // btnProductDetail
      // 
      this.btnProductDetail.Location = new System.Drawing.Point(3, 2);
      this.btnProductDetail.Name = "btnProductDetail";
      this.btnProductDetail.Size = new System.Drawing.Size(57, 31);
      this.btnProductDetail.TabIndex = 9;
      this.btnProductDetail.Text = "Detail";
      this.btnProductDetail.UseVisualStyleBackColor = true;
      this.btnProductDetail.Click += new System.EventHandler(this.btnProductDetail_Click);
      // 
      // lblAvg5
      // 
      this.lblAvg5.AutoSize = true;
      this.lblAvg5.Location = new System.Drawing.Point(359, 74);
      this.lblAvg5.Name = "lblAvg5";
      this.lblAvg5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblAvg5.Size = new System.Drawing.Size(19, 13);
      this.lblAvg5.TabIndex = 16;
      this.lblAvg5.Text = "45";
      // 
      // lblAvg4
      // 
      this.lblAvg4.AutoSize = true;
      this.lblAvg4.Location = new System.Drawing.Point(281, 74);
      this.lblAvg4.Name = "lblAvg4";
      this.lblAvg4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblAvg4.Size = new System.Drawing.Size(19, 13);
      this.lblAvg4.TabIndex = 15;
      this.lblAvg4.Text = "45";
      // 
      // lblAvg3
      // 
      this.lblAvg3.AutoSize = true;
      this.lblAvg3.Location = new System.Drawing.Point(206, 74);
      this.lblAvg3.Name = "lblAvg3";
      this.lblAvg3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblAvg3.Size = new System.Drawing.Size(19, 13);
      this.lblAvg3.TabIndex = 14;
      this.lblAvg3.Text = "45";
      // 
      // lblAvg2
      // 
      this.lblAvg2.AutoSize = true;
      this.lblAvg2.Location = new System.Drawing.Point(132, 74);
      this.lblAvg2.Name = "lblAvg2";
      this.lblAvg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblAvg2.Size = new System.Drawing.Size(19, 13);
      this.lblAvg2.TabIndex = 13;
      this.lblAvg2.Text = "45";
      // 
      // lblAvg1
      // 
      this.lblAvg1.AutoSize = true;
      this.lblAvg1.Location = new System.Drawing.Point(64, 74);
      this.lblAvg1.Name = "lblAvg1";
      this.lblAvg1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblAvg1.Size = new System.Drawing.Size(19, 13);
      this.lblAvg1.TabIndex = 12;
      this.lblAvg1.Text = "45";
      // 
      // lblMin5
      // 
      this.lblMin5.AutoSize = true;
      this.lblMin5.Location = new System.Drawing.Point(359, 44);
      this.lblMin5.Name = "lblMin5";
      this.lblMin5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblMin5.Size = new System.Drawing.Size(19, 13);
      this.lblMin5.TabIndex = 11;
      this.lblMin5.Text = "45";
      // 
      // lblMin4
      // 
      this.lblMin4.AutoSize = true;
      this.lblMin4.Location = new System.Drawing.Point(281, 44);
      this.lblMin4.Name = "lblMin4";
      this.lblMin4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblMin4.Size = new System.Drawing.Size(19, 13);
      this.lblMin4.TabIndex = 10;
      this.lblMin4.Text = "45";
      // 
      // lblMin3
      // 
      this.lblMin3.AutoSize = true;
      this.lblMin3.Location = new System.Drawing.Point(206, 44);
      this.lblMin3.Name = "lblMin3";
      this.lblMin3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblMin3.Size = new System.Drawing.Size(19, 13);
      this.lblMin3.TabIndex = 9;
      this.lblMin3.Text = "45";
      // 
      // lblMin2
      // 
      this.lblMin2.AutoSize = true;
      this.lblMin2.Location = new System.Drawing.Point(132, 44);
      this.lblMin2.Name = "lblMin2";
      this.lblMin2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblMin2.Size = new System.Drawing.Size(19, 13);
      this.lblMin2.TabIndex = 8;
      this.lblMin2.Text = "45";
      // 
      // lblMin1
      // 
      this.lblMin1.AutoSize = true;
      this.lblMin1.Location = new System.Drawing.Point(64, 44);
      this.lblMin1.Name = "lblMin1";
      this.lblMin1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.lblMin1.Size = new System.Drawing.Size(19, 13);
      this.lblMin1.TabIndex = 7;
      this.lblMin1.Text = "45";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(359, 13);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(19, 13);
      this.label7.TabIndex = 6;
      this.label7.Text = "48";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(281, 13);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(19, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "47";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(206, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(19, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "46";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(132, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(19, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "45";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(64, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(19, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "44";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Avg:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Min:";
      // 
      // gvProdukty
      // 
      this.gvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvProdukty.Location = new System.Drawing.Point(16, 39);
      this.gvProdukty.Name = "gvProdukty";
      this.gvProdukty.Size = new System.Drawing.Size(180, 150);
      this.gvProdukty.TabIndex = 7;
      this.gvProdukty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProdukty_CellContentClick);
      this.gvProdukty.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProdukty_ColumnHeaderMouseClick);
      this.gvProdukty.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvProdukty_DataBindingComplete);
      this.gvProdukty.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProdukty_RowEnter);
      // 
      // cmbPairType
      // 
      this.cmbPairType.FormattingEnabled = true;
      this.cmbPairType.Location = new System.Drawing.Point(26, 236);
      this.cmbPairType.Name = "cmbPairType";
      this.cmbPairType.Size = new System.Drawing.Size(121, 21);
      this.cmbPairType.TabIndex = 6;
      this.cmbPairType.DisplayMemberChanged += new System.EventHandler(this.cmbPairType_DisplayMemberChanged);
      // 
      // FrmPair
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1222, 620);
      this.Controls.Add(this.splitContainer1);
      this.Name = "FrmPair";
      this.Text = "Porovnávání cen";
      this.Load += new System.EventHandler(this.FrmPair_Load);
      this.Resize += new System.EventHandler(this.FrmPair_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.gvPair)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvProdukty)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Invoicing.Component.DataGridViewExt gvPair;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearchString;
    private System.Windows.Forms.Button btnPorovnej;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ComboBox cmbPairType;
    private Component.DataGridViewExt gvProdukty;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblAvg5;
    private System.Windows.Forms.Label lblAvg4;
    private System.Windows.Forms.Label lblAvg3;
    private System.Windows.Forms.Label lblAvg2;
    private System.Windows.Forms.Label lblAvg1;
    private System.Windows.Forms.Label lblMin5;
    private System.Windows.Forms.Label lblMin4;
    private System.Windows.Forms.Label lblMin3;
    private System.Windows.Forms.Label lblMin2;
    private System.Windows.Forms.Label lblMin1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnProductDetail;
    private System.Windows.Forms.Button btnPairDetail;
    private System.Windows.Forms.Label lblPairStatus;
    private System.Windows.Forms.Label lblPairRow;
  }
}