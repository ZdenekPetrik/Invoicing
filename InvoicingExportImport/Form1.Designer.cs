﻿namespace InvoicingExportImport
{
  partial class Form1
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
      this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menu_ImportAbasto = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // importToolStripMenuItem
      // 
      this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ImportAbasto});
      this.importToolStripMenuItem.Name = "importToolStripMenuItem";
      this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.importToolStripMenuItem.Text = "Import";
      // 
      // menu_ImportAbasto
      // 
      this.menu_ImportAbasto.Name = "menu_ImportAbasto";
      this.menu_ImportAbasto.Size = new System.Drawing.Size(152, 22);
      this.menu_ImportAbasto.Text = "ABASTO";
      this.menu_ImportAbasto.Click += new System.EventHandler(this.menu_ImportAbasto_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1220, 537);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Invoicing Export/Import";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menu_ImportAbasto;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

