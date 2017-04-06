namespace Invoicing.Forms
{
  partial class frmAbout
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtVersionPopis = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(215, 75);
      this.label1.TabIndex = 0;
      this.label1.Text = "SSCP";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label2.Location = new System.Drawing.Point(205, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 42);
      this.label2.TabIndex = 1;
      this.label2.Text = "Invoicing";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(36, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(139, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Verze: 1.0.5         (6.4.2017)";
      // 
      // txtVersionPopis
      // 
      this.txtVersionPopis.BackColor = System.Drawing.SystemColors.Menu;
      this.txtVersionPopis.Location = new System.Drawing.Point(13, 139);
      this.txtVersionPopis.Multiline = true;
      this.txtVersionPopis.Name = "txtVersionPopis";
      this.txtVersionPopis.Size = new System.Drawing.Size(324, 147);
      this.txtVersionPopis.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(143, 292);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "OK ";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 323);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtVersionPopis);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.Text = "... o aplikaci";
      this.Load += new System.EventHandler(this.frmAbout_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtVersionPopis;
    private System.Windows.Forms.Button button1;
  }
}