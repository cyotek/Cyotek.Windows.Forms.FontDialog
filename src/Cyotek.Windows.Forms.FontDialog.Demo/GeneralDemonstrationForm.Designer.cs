namespace Cyotek.Windows.Forms.Demo
{
  partial class GeneralDemonstrationForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralDemonstrationForm));
      this.optionsSplitContainer = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.closeButton = new System.Windows.Forms.Button();
      this.aboutButton = new System.Windows.Forms.Button();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.sysFontDialog = new System.Windows.Forms.FontDialog();
      this.fontDialog = new Cyotek.Windows.Forms.FontDialog();
      this.groupBox1 = new Cyotek.Windows.Forms.GroupBox();
      this.showWin32DialogButton = new System.Windows.Forms.Button();
      this.newFontDialogGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.showFontDialogButton = new System.Windows.Forms.Button();
      this.previewGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.previewLabel = new System.Windows.Forms.Label();
      this.propertyGrid = new Cyotek.Windows.Forms.Demo.PropertyGrid();
      this.eventsListBox = new Cyotek.Windows.Forms.Demo.EventsListBox();
      this.optionsSplitContainer.Panel1.SuspendLayout();
      this.optionsSplitContainer.Panel2.SuspendLayout();
      this.optionsSplitContainer.SuspendLayout();
      this.panel1.SuspendLayout();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.newFontDialogGroupBox.SuspendLayout();
      this.previewGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // optionsSplitContainer
      // 
      this.optionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.optionsSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.optionsSplitContainer.Name = "optionsSplitContainer";
      this.optionsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // optionsSplitContainer.Panel1
      // 
      this.optionsSplitContainer.Panel1.Controls.Add(this.propertyGrid);
      // 
      // optionsSplitContainer.Panel2
      // 
      this.optionsSplitContainer.Panel2.Controls.Add(this.eventsListBox);
      this.optionsSplitContainer.Panel2.Controls.Add(this.panel1);
      this.optionsSplitContainer.Size = new System.Drawing.Size(471, 507);
      this.optionsSplitContainer.SplitterDistance = 249;
      this.optionsSplitContainer.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.closeButton);
      this.panel1.Controls.Add(this.aboutButton);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 216);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(471, 38);
      this.panel1.TabIndex = 1;
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(384, 3);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 1;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // aboutButton
      // 
      this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.aboutButton.Location = new System.Drawing.Point(303, 3);
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Size = new System.Drawing.Size(75, 23);
      this.aboutButton.TabIndex = 0;
      this.aboutButton.Text = "&About";
      this.aboutButton.UseVisualStyleBackColor = true;
      this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Location = new System.Drawing.Point(0, 0);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer.Panel1.Controls.Add(this.newFontDialogGroupBox);
      this.splitContainer.Panel1.Controls.Add(this.previewGroupBox);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.optionsSplitContainer);
      this.splitContainer.Size = new System.Drawing.Size(791, 507);
      this.splitContainer.SplitterDistance = 316;
      this.splitContainer.TabIndex = 0;
      // 
      // sysFontDialog
      // 
      this.sysFontDialog.Apply += new System.EventHandler(this.sysFontDialog_Apply);
      // 
      // fontDialog
      // 
      this.fontDialog.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
      this.fontDialog.HelpRequest += new System.EventHandler(this.fontDialog_HelpRequest);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.showWin32DialogButton);
      this.groupBox1.Location = new System.Drawing.Point(12, 253);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(301, 101);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "System.Windows.Forms.FontDialog Implementation";
      // 
      // showWin32DialogButton
      // 
      this.showWin32DialogButton.Location = new System.Drawing.Point(6, 19);
      this.showWin32DialogButton.Name = "showWin32DialogButton";
      this.showWin32DialogButton.Size = new System.Drawing.Size(75, 23);
      this.showWin32DialogButton.TabIndex = 0;
      this.showWin32DialogButton.Text = "Show &Win32 Dialog";
      this.showWin32DialogButton.UseVisualStyleBackColor = true;
      this.showWin32DialogButton.Click += new System.EventHandler(this.showWin32DialogButton_Click);
      // 
      // newFontDialogGroupBox
      // 
      this.newFontDialogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.newFontDialogGroupBox.Controls.Add(this.showFontDialogButton);
      this.newFontDialogGroupBox.Location = new System.Drawing.Point(12, 148);
      this.newFontDialogGroupBox.Name = "newFontDialogGroupBox";
      this.newFontDialogGroupBox.Size = new System.Drawing.Size(301, 101);
      this.newFontDialogGroupBox.TabIndex = 1;
      this.newFontDialogGroupBox.TabStop = false;
      this.newFontDialogGroupBox.Text = "Cyotek FontDialog Implementation";
      // 
      // showFontDialogButton
      // 
      this.showFontDialogButton.Location = new System.Drawing.Point(6, 19);
      this.showFontDialogButton.Name = "showFontDialogButton";
      this.showFontDialogButton.Size = new System.Drawing.Size(75, 23);
      this.showFontDialogButton.TabIndex = 0;
      this.showFontDialogButton.Text = "&Show";
      this.showFontDialogButton.UseVisualStyleBackColor = true;
      this.showFontDialogButton.Click += new System.EventHandler(this.showFontDialogButton_Click);
      // 
      // previewGroupBox
      // 
      this.previewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.previewGroupBox.Controls.Add(this.previewLabel);
      this.previewGroupBox.Location = new System.Drawing.Point(12, 12);
      this.previewGroupBox.Name = "previewGroupBox";
      this.previewGroupBox.Size = new System.Drawing.Size(302, 130);
      this.previewGroupBox.TabIndex = 0;
      this.previewGroupBox.TabStop = false;
      this.previewGroupBox.Text = "Preview";
      // 
      // previewLabel
      // 
      this.previewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.previewLabel.AutoEllipsis = true;
      this.previewLabel.Location = new System.Drawing.Point(6, 16);
      this.previewLabel.Name = "previewLabel";
      this.previewLabel.Size = new System.Drawing.Size(290, 111);
      this.previewLabel.TabIndex = 0;
      this.previewLabel.Text = "AaBbYyZz";
      this.previewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // propertyGrid
      // 
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.SelectedObject = this.fontDialog;
      this.propertyGrid.Size = new System.Drawing.Size(471, 249);
      this.propertyGrid.TabIndex = 0;
      // 
      // eventsListBox
      // 
      this.eventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.eventsListBox.FormattingEnabled = true;
      this.eventsListBox.Location = new System.Drawing.Point(0, 0);
      this.eventsListBox.Name = "eventsListBox";
      this.eventsListBox.Size = new System.Drawing.Size(471, 216);
      this.eventsListBox.TabIndex = 0;
      // 
      // GeneralDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(791, 507);
      this.Controls.Add(this.splitContainer);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "GeneralDemonstrationForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "General Demonstration";
      this.optionsSplitContainer.Panel1.ResumeLayout(false);
      this.optionsSplitContainer.Panel2.ResumeLayout(false);
      this.optionsSplitContainer.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.newFontDialogGroupBox.ResumeLayout(false);
      this.previewGroupBox.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Cyotek.Windows.Forms.FontDialog fontDialog;
    private EventsListBox eventsListBox;
    private PropertyGrid propertyGrid;
    private System.Windows.Forms.SplitContainer optionsSplitContainer;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.Button showFontDialogButton;
    private System.Windows.Forms.Button showWin32DialogButton;
    private System.Windows.Forms.Label previewLabel;
    private GroupBox groupBox1;
    private GroupBox newFontDialogGroupBox;
    private GroupBox previewGroupBox;
    private System.Windows.Forms.FontDialog sysFontDialog;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button aboutButton;
  }
}
