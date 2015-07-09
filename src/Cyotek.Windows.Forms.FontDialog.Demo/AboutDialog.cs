/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CommonMark;
using Cyotek.Windows.Forms.Demo.Properties;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class AboutDialog : BaseForm
  {
    #region Constructors

    public AboutDialog()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Static Methods

    internal static void ShowAboutDialog()
    {
      using (Form dialog = new AboutDialog())
      {
        dialog.ShowDialog();
      }
    }

    #endregion

    #region Properties

    protected TabControl TabControl { get; private set; }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        FileVersionInfo info;
        Assembly assembly;
        string title;

        assembly = typeof(FontDialog).Assembly;
        info = FileVersionInfo.GetVersionInfo(assembly.Location);
        title = info.ProductName;

        this.Text = string.Format("About {0}", title);
        nameLabel.Text = title;
        versionLabel.Text = string.Format("Version {0}", info.FileVersion);
        copyrightLabel.Text = info.LegalCopyright;

        this.AddReadme("changelog.md");
        this.AddReadme("readme.md");
        this.AddReadme("license.txt");

        this.LoadDocumentForTab(this.TabControl.SelectedTab);
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      if (this.TabControl != null)
      {
        this.TabControl.SetBounds(this.TabControl.Left, this.TabControl.Top, this.ClientSize.Width - (this.TabControl.Left * 2), this.ClientSize.Height - (this.TabControl.Top + footerGroupBox.Height + this.TabControl.Left));
      }
    }

    private void AddReadme(string fileName)
    {
      TabControl.TabPages.Add(new TabPage
                              {
                                UseVisualStyleBackColor = true,
                                Padding = new Padding(9),
                                ToolTipText = this.GetFullReadmePath(fileName),
                                Text = fileName,
                                Tag = fileName
                              });
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void docsTabControl_Selecting(object sender, TabControlCancelEventArgs e)
    {
      this.LoadDocumentForTab(e.TabPage);
    }

    private void footerGroupBox_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, footerGroupBox.Width, 0);
      e.Graphics.DrawLine(SystemPens.ControlLightLight, 0, 1, footerGroupBox.Width, 1);
    }

    private string GetFullReadmePath(string fileName)
    {
      return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
    }

    private void LoadDocumentForTab(TabPage page)
    {
      if (page != null && page.Controls.Count == 0 && page.Tag != null)
      {
        Control documentView;
        string fullPath;
        string text;

        Cursor.Current = Cursors.WaitCursor;

        Debug.Print("Loading readme: {0}", page.Tag);

        fullPath = this.GetFullReadmePath(page.Tag.ToString());
        text = File.Exists(fullPath) ? File.ReadAllText(fullPath) : string.Format("Cannot find file '{0}'", fullPath);

        if (text.IndexOf('\n') != -1 && text.IndexOf('\r') == -1)
        {
          text = text.Replace("\n", "\r\n");
        }

        switch (Path.GetExtension(fullPath))
        {
          case ".md":
            documentView = new HtmlPanel
                           {
                             Dock = DockStyle.Fill,
                             BaseStylesheet = Resources.CSS,
                             Text = string.Concat("<html><body>", CommonMarkConverter.Convert(text), "</body></html>") // HACK: HTML panel screws up rendering if a <body> tag isn't present
                           };
            break;
          default:
            documentView = new TextBox
                           {
                             ReadOnly = true,
                             Multiline = true,
                             WordWrap = true,
                             ScrollBars = ScrollBars.Vertical,
                             Dock = DockStyle.Fill,
                             Text = text
                           };
            break;
        }

        page.Controls.Add(documentView);

        Cursor.Current = Cursors.Default;
      }
    }

    private void webLinkLabel_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(((Control)sender).Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Unable to start the specified URI.\n\n{0}", ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    #endregion
  }
}
