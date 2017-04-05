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
      this.viewFakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewDodavateléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Menu_Dodavatele = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zakázka,
            this.Menu_Faktury,
            this.Menu_Dodavatele});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
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
      // 
      // Menu_Faktury
      // 
      this.Menu_Faktury.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFakturyToolStripMenuItem,
            this.viewScanToolStripMenuItem,
            this.viewDodavateléToolStripMenuItem,
            this.toolStripSeparator1,
            this.detailToolStripMenuItem});
      this.Menu_Faktury.Name = "Menu_Faktury";
      this.Menu_Faktury.Size = new System.Drawing.Size(58, 20);
      this.Menu_Faktury.Text = "Faktury";
      // 
      // viewFakturyToolStripMenuItem
      // 
      this.viewFakturyToolStripMenuItem.Name = "viewFakturyToolStripMenuItem";
      this.viewFakturyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.viewFakturyToolStripMenuItem.Text = "View Faktury";
      // 
      // viewScanToolStripMenuItem
      // 
      this.viewScanToolStripMenuItem.Name = "viewScanToolStripMenuItem";
      this.viewScanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.viewScanToolStripMenuItem.Text = "View Scan (PDF)";
      // 
      // viewDodavateléToolStripMenuItem
      // 
      this.viewDodavateléToolStripMenuItem.Name = "viewDodavateléToolStripMenuItem";
      this.viewDodavateléToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.viewDodavateléToolStripMenuItem.Text = "View Dodavatelé";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
      // 
      // detailToolStripMenuItem
      // 
      this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
      this.detailToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.detailToolStripMenuItem.Text = "Detail";
      // 
      // Menu_Dodavatele
      // 
      this.Menu_Dodavatele.Name = "Menu_Dodavatele";
      this.Menu_Dodavatele.Size = new System.Drawing.Size(78, 20);
      this.Menu_Dodavatele.Text = "Dodavatelé";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 613);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(71, 97);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(80, 17);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1143, 635);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmMain";
      this.Text = "Invoicing";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem viewFakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDodavateléToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Dodavatele;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}