namespace Invoicing.Forms
{
    partial class frmMain
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.Zakázka = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_OrderNew = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_OrderChange = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_OrderDetail = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_Faktury = new System.Windows.Forms.ToolStripMenuItem();
      this.menuFaktury = new System.Windows.Forms.ToolStripMenuItem();
      this.menuScanPDF = new System.Windows.Forms.ToolStripMenuItem();
      this.menuDodavatele = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuHorniDetail = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.menuHorniAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.menuHorniEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.menuHorniDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.menuHorniRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_Dodavatele = new System.Windows.Forms.ToolStripMenuItem();
      this.změnaFázeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fáze01FakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fáze12PoložkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fáze23PárováníPoložekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fáze34ReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fáze45CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.položkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_ItemsNew = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_ItemsEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControlsUp = new System.Windows.Forms.TabControl();
      this.tabInvoices = new System.Windows.Forms.TabPage();
      this.tabSuppliers = new System.Windows.Forms.TabPage();
      this.tblScanPDF = new System.Windows.Forms.TabPage();
      this.ctrlListItems1 = new Invoicing.Controls.ctrlListItems();
      this.panelOrder = new System.Windows.Forms.Panel();
      this.menu_ParovaniCen = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_Refresh = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControlsUp.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zakázka,
            this.Menu_Faktury,
            this.Menu_Dodavatele,
            this.změnaFázeToolStripMenuItem,
            this.položkyToolStripMenuItem,
            this.menu_ParovaniCen,
            this.menu_Refresh});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // Zakázka
      // 
      this.Zakázka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OrderNew,
            this.Menu_OrderChange,
            this.Menu_OrderDetail});
      this.Zakázka.Name = "Zakázka";
      this.Zakázka.Size = new System.Drawing.Size(61, 20);
      this.Zakázka.Text = "Zakázka";
      // 
      // Menu_OrderNew
      // 
      this.Menu_OrderNew.Name = "Menu_OrderNew";
      this.Menu_OrderNew.Size = new System.Drawing.Size(152, 22);
      this.Menu_OrderNew.Text = "Nová ...";
      this.Menu_OrderNew.Click += new System.EventHandler(this.Menu_OrderNew_Click);
      // 
      // Menu_OrderChange
      // 
      this.Menu_OrderChange.Name = "Menu_OrderChange";
      this.Menu_OrderChange.Size = new System.Drawing.Size(152, 22);
      this.Menu_OrderChange.Text = "Vyber ...";
      this.Menu_OrderChange.Click += new System.EventHandler(this.Menu_OrderChange_Click);
      // 
      // Menu_OrderDetail
      // 
      this.Menu_OrderDetail.Name = "Menu_OrderDetail";
      this.Menu_OrderDetail.Size = new System.Drawing.Size(152, 22);
      this.Menu_OrderDetail.Text = "Detail";
      this.Menu_OrderDetail.Click += new System.EventHandler(this.Menu_OrderDetail_Click);
      // 
      // Menu_Faktury
      // 
      this.Menu_Faktury.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFaktury,
            this.menuScanPDF,
            this.menuDodavatele,
            this.toolStripSeparator1,
            this.menuHorniDetail,
            this.toolStripSeparator2,
            this.menuHorniAdd,
            this.menuHorniEdit,
            this.menuHorniDelete,
            this.toolStripSeparator3,
            this.menuHorniRefresh});
      this.Menu_Faktury.Name = "Menu_Faktury";
      this.Menu_Faktury.Size = new System.Drawing.Size(58, 20);
      this.Menu_Faktury.Text = "Faktury";
      // 
      // menuFaktury
      // 
      this.menuFaktury.Checked = true;
      this.menuFaktury.CheckOnClick = true;
      this.menuFaktury.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuFaktury.Name = "menuFaktury";
      this.menuFaktury.Size = new System.Drawing.Size(161, 22);
      this.menuFaktury.Text = "View Faktury";
      // 
      // menuScanPDF
      // 
      this.menuScanPDF.Name = "menuScanPDF";
      this.menuScanPDF.Size = new System.Drawing.Size(161, 22);
      this.menuScanPDF.Text = "View Scan (PDF)";
      // 
      // menuDodavatele
      // 
      this.menuDodavatele.Name = "menuDodavatele";
      this.menuDodavatele.Size = new System.Drawing.Size(161, 22);
      this.menuDodavatele.Text = "View Dodavatelé";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
      // 
      // menuHorniDetail
      // 
      this.menuHorniDetail.Name = "menuHorniDetail";
      this.menuHorniDetail.Size = new System.Drawing.Size(161, 22);
      this.menuHorniDetail.Text = "Detail";
      this.menuHorniDetail.Click += new System.EventHandler(this.menuHorniDetail_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
      // 
      // menuHorniAdd
      // 
      this.menuHorniAdd.Name = "menuHorniAdd";
      this.menuHorniAdd.Size = new System.Drawing.Size(161, 22);
      this.menuHorniAdd.Text = "Add   ...";
      this.menuHorniAdd.Click += new System.EventHandler(this.menuHorniAdd_Click);
      // 
      // menuHorniEdit
      // 
      this.menuHorniEdit.Name = "menuHorniEdit";
      this.menuHorniEdit.Size = new System.Drawing.Size(161, 22);
      this.menuHorniEdit.Text = "Edit   ... ";
      this.menuHorniEdit.Click += new System.EventHandler(this.menuHorniEdit_Click);
      // 
      // menuHorniDelete
      // 
      this.menuHorniDelete.Name = "menuHorniDelete";
      this.menuHorniDelete.Size = new System.Drawing.Size(161, 22);
      this.menuHorniDelete.Text = "Delete   ...";
      this.menuHorniDelete.Click += new System.EventHandler(this.menuHorniDelete_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
      // 
      // menuHorniRefresh
      // 
      this.menuHorniRefresh.Name = "menuHorniRefresh";
      this.menuHorniRefresh.Size = new System.Drawing.Size(161, 22);
      this.menuHorniRefresh.Text = "Refresh";
      this.menuHorniRefresh.Click += new System.EventHandler(this.menuHorniRefresh_Click);
      // 
      // Menu_Dodavatele
      // 
      this.Menu_Dodavatele.Name = "Menu_Dodavatele";
      this.Menu_Dodavatele.Size = new System.Drawing.Size(78, 20);
      this.Menu_Dodavatele.Text = "Dodavatelé";
      // 
      // změnaFázeToolStripMenuItem
      // 
      this.změnaFázeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fáze01FakturyToolStripMenuItem,
            this.fáze12PoložkyToolStripMenuItem,
            this.fáze23PárováníPoložekToolStripMenuItem,
            this.fáze34ReportingToolStripMenuItem,
            this.fáze45CloseToolStripMenuItem});
      this.změnaFázeToolStripMenuItem.Name = "změnaFázeToolStripMenuItem";
      this.změnaFázeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
      this.změnaFázeToolStripMenuItem.Text = "Fáze Editace";
      // 
      // fáze01FakturyToolStripMenuItem
      // 
      this.fáze01FakturyToolStripMenuItem.Name = "fáze01FakturyToolStripMenuItem";
      this.fáze01FakturyToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
      this.fáze01FakturyToolStripMenuItem.Text = "Fáze  0 -> 1 Hlavičky Faktury ";
      this.fáze01FakturyToolStripMenuItem.Click += new System.EventHandler(this.fáze01FakturyToolStripMenuItem_Click);
      // 
      // fáze12PoložkyToolStripMenuItem
      // 
      this.fáze12PoložkyToolStripMenuItem.Name = "fáze12PoložkyToolStripMenuItem";
      this.fáze12PoložkyToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
      this.fáze12PoložkyToolStripMenuItem.Text = "Fáze 1 -> 2 Položky Faktur";
      this.fáze12PoložkyToolStripMenuItem.Click += new System.EventHandler(this.fáze12PoložkyToolStripMenuItem_Click);
      // 
      // fáze23PárováníPoložekToolStripMenuItem
      // 
      this.fáze23PárováníPoložekToolStripMenuItem.Name = "fáze23PárováníPoložekToolStripMenuItem";
      this.fáze23PárováníPoložekToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
      this.fáze23PárováníPoložekToolStripMenuItem.Text = "Fáze 2 ->  3 Párování Položek";
      this.fáze23PárováníPoložekToolStripMenuItem.Click += new System.EventHandler(this.fáze23PárováníPoložekToolStripMenuItem_Click);
      // 
      // fáze34ReportingToolStripMenuItem
      // 
      this.fáze34ReportingToolStripMenuItem.Name = "fáze34ReportingToolStripMenuItem";
      this.fáze34ReportingToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
      this.fáze34ReportingToolStripMenuItem.Text = "Fáze 3 -> 4  Reporting";
      this.fáze34ReportingToolStripMenuItem.Click += new System.EventHandler(this.fáze34ReportingToolStripMenuItem_Click);
      // 
      // fáze45CloseToolStripMenuItem
      // 
      this.fáze45CloseToolStripMenuItem.Name = "fáze45CloseToolStripMenuItem";
      this.fáze45CloseToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
      this.fáze45CloseToolStripMenuItem.Text = "Fáze 4 -> 5 Close";
      this.fáze45CloseToolStripMenuItem.Click += new System.EventHandler(this.fáze45CloseToolStripMenuItem_Click);
      // 
      // položkyToolStripMenuItem
      // 
      this.položkyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ItemsNew,
            this.menu_ItemsEdit});
      this.položkyToolStripMenuItem.Name = "položkyToolStripMenuItem";
      this.položkyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.položkyToolStripMenuItem.Text = "Položky";
      // 
      // menu_ItemsNew
      // 
      this.menu_ItemsNew.Name = "menu_ItemsNew";
      this.menu_ItemsNew.Size = new System.Drawing.Size(152, 22);
      this.menu_ItemsNew.Text = "Add ...";
      this.menu_ItemsNew.Click += new System.EventHandler(this.menu_ItemsNew_Click);
      // 
      // menu_ItemsEdit
      // 
      this.menu_ItemsEdit.Name = "menu_ItemsEdit";
      this.menu_ItemsEdit.Size = new System.Drawing.Size(152, 22);
      this.menu_ItemsEdit.Text = "Edit ...";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 613);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1276, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Location = new System.Drawing.Point(12, 68);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabControlsUp);
      this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.ctrlListItems1);
      this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
      this.splitContainer1.Size = new System.Drawing.Size(1083, 434);
      this.splitContainer1.SplitterDistance = 216;
      this.splitContainer1.TabIndex = 3;
      // 
      // tabControlsUp
      // 
      this.tabControlsUp.Controls.Add(this.tabInvoices);
      this.tabControlsUp.Controls.Add(this.tabSuppliers);
      this.tabControlsUp.Controls.Add(this.tblScanPDF);
      this.tabControlsUp.Location = new System.Drawing.Point(-2, 3);
      this.tabControlsUp.Name = "tabControlsUp";
      this.tabControlsUp.SelectedIndex = 0;
      this.tabControlsUp.Size = new System.Drawing.Size(998, 206);
      this.tabControlsUp.TabIndex = 3;
      this.tabControlsUp.SelectedIndexChanged += new System.EventHandler(this.tabControlsUp_SelectedIndexChanged);
      this.tabControlsUp.Resize += new System.EventHandler(this.tabControlsUp_Resize);
      // 
      // tabInvoices
      // 
      this.tabInvoices.Location = new System.Drawing.Point(4, 22);
      this.tabInvoices.Name = "tabInvoices";
      this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
      this.tabInvoices.Size = new System.Drawing.Size(990, 180);
      this.tabInvoices.TabIndex = 0;
      this.tabInvoices.Text = "Faktury";
      this.tabInvoices.UseVisualStyleBackColor = true;
      // 
      // tabSuppliers
      // 
      this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
      this.tabSuppliers.Name = "tabSuppliers";
      this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
      this.tabSuppliers.Size = new System.Drawing.Size(990, 180);
      this.tabSuppliers.TabIndex = 1;
      this.tabSuppliers.Text = "Dodavatelé";
      this.tabSuppliers.UseVisualStyleBackColor = true;
      // 
      // tblScanPDF
      // 
      this.tblScanPDF.Location = new System.Drawing.Point(4, 22);
      this.tblScanPDF.Name = "tblScanPDF";
      this.tblScanPDF.Size = new System.Drawing.Size(990, 180);
      this.tblScanPDF.TabIndex = 2;
      this.tblScanPDF.Text = "Scan PDF";
      this.tblScanPDF.UseVisualStyleBackColor = true;
      // 
      // ctrlListItems1
      // 
      this.ctrlListItems1.Location = new System.Drawing.Point(4, 4);
      this.ctrlListItems1.Name = "ctrlListItems1";
      this.ctrlListItems1.Size = new System.Drawing.Size(662, 167);
      this.ctrlListItems1.TabIndex = 0;
      // 
      // panelOrder
      // 
      this.panelOrder.Location = new System.Drawing.Point(16, 36);
      this.panelOrder.Name = "panelOrder";
      this.panelOrder.Size = new System.Drawing.Size(1079, 26);
      this.panelOrder.TabIndex = 4;
      // 
      // menu_ParovaniCen
      // 
      this.menu_ParovaniCen.Name = "menu_ParovaniCen";
      this.menu_ParovaniCen.Size = new System.Drawing.Size(87, 20);
      this.menu_ParovaniCen.Text = "Párování cen";
      this.menu_ParovaniCen.Click += new System.EventHandler(this.menu_ParovaniCen_Click);
      // 
      // menu_Refresh
      // 
      this.menu_Refresh.Name = "menu_Refresh";
      this.menu_Refresh.Size = new System.Drawing.Size(58, 20);
      this.menu_Refresh.Text = "Refresh";
      this.menu_Refresh.Click += new System.EventHandler(this.menu_Refresh_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1276, 635);
      this.Controls.Add(this.panelOrder);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmMain";
      this.Text = "Invoicing";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.Resize += new System.EventHandler(this.frmMain_Resize);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControlsUp.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Zakázka;
        private System.Windows.Forms.ToolStripMenuItem Menu_Faktury;
        private System.Windows.Forms.ToolStripMenuItem Menu_OrderNew;
        private System.Windows.Forms.ToolStripMenuItem Menu_OrderChange;
        private System.Windows.Forms.ToolStripMenuItem Menu_OrderDetail;
        private System.Windows.Forms.ToolStripMenuItem menuFaktury;
        private System.Windows.Forms.ToolStripMenuItem menuScanPDF;
        private System.Windows.Forms.ToolStripMenuItem menuDodavatele;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuHorniDetail;
        private System.Windows.Forms.ToolStripMenuItem Menu_Dodavatele;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuHorniAdd;
        private System.Windows.Forms.ToolStripMenuItem menuHorniEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHorniDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlsUp;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tblScanPDF;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuHorniRefresh;
        private System.Windows.Forms.ToolStripMenuItem změnaFázeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáze01FakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáze12PoložkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáze23PárováníPoložekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáze34ReportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáze45CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem položkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ItemsNew;
        private System.Windows.Forms.ToolStripMenuItem menu_ItemsEdit;
        private Controls.ctrlListItems ctrlListItems1;
        private System.Windows.Forms.ToolStripMenuItem menu_ParovaniCen;
        private System.Windows.Forms.ToolStripMenuItem menu_Refresh;
    }
}