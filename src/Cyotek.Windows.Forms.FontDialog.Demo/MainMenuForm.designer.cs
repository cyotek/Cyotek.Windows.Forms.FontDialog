namespace Cyotek.Windows.Forms.Demo
{
  partial class MainMenuForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
      this.demoGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.generalDemonstrationButton = new System.Windows.Forms.Button();
      this.demoGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // demoGroupBox
      // 
      this.demoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.demoGroupBox.Controls.Add(this.generalDemonstrationButton);
      this.demoGroupBox.Location = new System.Drawing.Point(31, 65);
      this.demoGroupBox.Name = "demoGroupBox";
      this.demoGroupBox.Size = new System.Drawing.Size(444, 426);
      this.demoGroupBox.TabIndex = 0;
      this.demoGroupBox.TabStop = false;
      this.demoGroupBox.Text = "Available Demonstrations";
      // 
      // generalDemonstrationButton
      // 
      this.generalDemonstrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.generalDemonstrationButton.Location = new System.Drawing.Point(6, 22);
      this.generalDemonstrationButton.Name = "generalDemonstrationButton";
      this.generalDemonstrationButton.Size = new System.Drawing.Size(432, 27);
      this.generalDemonstrationButton.TabIndex = 0;
      this.generalDemonstrationButton.Text = "&General Demonstration";
      this.generalDemonstrationButton.UseVisualStyleBackColor = true;
      this.generalDemonstrationButton.Click += new System.EventHandler(this.generalDemonstrationButton_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 585);
      this.Controls.Add(this.demoGroupBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainMenuForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.Controls.SetChildIndex(this.demoGroupBox, 0);
      this.demoGroupBox.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private GroupBox demoGroupBox;
    private System.Windows.Forms.Button generalDemonstrationButton;



  }
}

