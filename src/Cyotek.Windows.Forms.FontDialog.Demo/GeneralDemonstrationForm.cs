/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class GeneralDemonstrationForm : Form
  {
    #region Constructors

    public GeneralDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      this.UpdatePreview();
    }

    private void aboutButton_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void ApplySysFont()
    {
      fontDialog.Font = sysFontDialog.Font;
      fontDialog.Color = sysFontDialog.Color;

      this.UpdatePreview();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void fontDialog_Apply(object sender, EventArgs e)
    {
      eventsListBox.AddEvent("Apply");

      this.UpdatePreview();
    }

    private void fontDialog_HelpRequest(object sender, EventArgs e)
    {
      eventsListBox.AddEvent("HelpRequest");
    }

    private void showFontDialogButton_Click(object sender, EventArgs e)
    {
      if (fontDialog.ShowDialog(this) == DialogResult.OK)
      {
        this.UpdatePreview();
      }
    }

    private void showWin32DialogButton_Click(object sender, EventArgs e)
    {
      sysFontDialog.ShowHelp = fontDialog.ShowHelp;
      sysFontDialog.ShowColor = fontDialog.ShowColor;
      sysFontDialog.ShowEffects = fontDialog.ShowEffects;
      sysFontDialog.ShowApply = fontDialog.ShowApply;
      sysFontDialog.MaxSize = fontDialog.MaxSize;
      sysFontDialog.Font = fontDialog.Font;
      sysFontDialog.FontMustExist = fontDialog.FontMustExist;
      sysFontDialog.AllowSimulations = fontDialog.AllowSimulations;
      sysFontDialog.AllowVectorFonts = fontDialog.AllowVectorFonts;
      sysFontDialog.Color = fontDialog.Color;
      sysFontDialog.AllowScriptChange = fontDialog.AllowScriptChange;
      sysFontDialog.AllowVerticalFonts = fontDialog.AllowVerticalFonts;
      sysFontDialog.FixedPitchOnly = fontDialog.FixedPitchOnly;
      sysFontDialog.MinSize = fontDialog.MinSize;
      sysFontDialog.ScriptsOnly = fontDialog.ScriptsOnly;

      if (sysFontDialog.ShowDialog(this) == DialogResult.OK)
      {
        this.ApplySysFont();
      }
    }

    private void sysFontDialog_Apply(object sender, EventArgs e)
    {
      this.ApplySysFont();
    }

    private void UpdatePreview()
    {
      previewLabel.Font = fontDialog.Font;
      previewLabel.ForeColor = fontDialog.Color;

      propertyGrid.Refresh();
    }

    #endregion
  }
}
