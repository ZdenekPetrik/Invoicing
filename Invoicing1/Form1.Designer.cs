namespace Invoicing
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
      this.btnTestEF = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnTestEF
      // 
      this.btnTestEF.Location = new System.Drawing.Point(13, 13);
      this.btnTestEF.Name = "btnTestEF";
      this.btnTestEF.Size = new System.Drawing.Size(75, 23);
      this.btnTestEF.TabIndex = 0;
      this.btnTestEF.Text = "Test EF";
      this.btnTestEF.UseVisualStyleBackColor = true;
      this.btnTestEF.Click += new System.EventHandler(this.btnTestEF_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnTestEF);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnTestEF;
  }
}

