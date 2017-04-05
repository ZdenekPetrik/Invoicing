namespace Invoicing.Controls
{
  partial class ctrlShowOrder
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblStatus = new System.Windows.Forms.Label();
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.lblState = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblStatus.Location = new System.Drawing.Point(853, 7);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(46, 17);
      this.lblStatus.TabIndex = 2;
      this.lblStatus.Text = "label1";
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblInfo.Location = new System.Drawing.Point(343, 7);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(46, 17);
      this.lblInfo.TabIndex = 1;
      this.lblInfo.Text = "label1";
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblName.Location = new System.Drawing.Point(86, 4);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(57, 20);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "label1";
      // 
      // lblState
      // 
      this.lblState.AutoSize = true;
      this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblState.Location = new System.Drawing.Point(3, 4);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(57, 20);
      this.lblState.TabIndex = 3;
      this.lblState.Text = "label1";
      // 
      // ctrlShowOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblState);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.lblName);
      this.Name = "ctrlShowOrder";
      this.Size = new System.Drawing.Size(1102, 34);
      this.Load += new System.EventHandler(this.ctrlShowOrder_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblState;
  }
}
