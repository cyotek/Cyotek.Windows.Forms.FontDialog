/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646832(v=vs.85).aspx

namespace Cyotek.Windows.Forms
{
  /// <summary>
  ///  Prompts the user to choose a font from among those installed on the local computer.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.CommonDialog"/>
  [DefaultEvent("Apply")]
  [DefaultProperty("Font")]
  [Description("Displays a dialog box that prompts the user to choose a font from those installed on the local computer.")]
  public class FontDialog : CommonDialog
  {
    #region Fields

    private Font _font;

    private int _maxSize;

    private int _minSize;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Cyotek.Windows.Forms.FontDialog"/> class.
    /// </summary>
    public FontDialog()
    {
      this.Reset();
    }

    #endregion

    #region Events

    /// <summary>
    /// Occurs when the user clicks the <strong>Apply</strong> button in the font dialog box.
    /// </summary>
    [Description("Occurs when the user clicks the Apply button.")]
    public event EventHandler Apply;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a value indicating whether the user can change the character set specified in the <strong>Script</strong> combo box to display a character set other than the one currently displayed.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the user can change the character set specified in the <strong>Script</strong> combo box; otherwise, <strong>false</strong>. The default value is <strong>true</strong>.
    /// </value>
    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Controls whether the character set of the font can be changed.")]
    public bool AllowScriptChange { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box allows graphics device interface (GDI) font simulations.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if font simulations are allowed; otherwise, <strong>false</strong>. The default value is <strong>true</strong>.
    /// </value>
    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Controls whether GDI font simulations are allowed.")]
    public bool AllowSimulations { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box allows vector font selections.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if vector fonts are allowed; otherwise, <strong>false</strong>. The default value is <strong>true</strong>.
    /// </value>
    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Controls whether vector fonts can be selected.")]
    public bool AllowVectorFonts { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box displays both vertical and horizontal fonts or only horizontal fonts.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if both vertical and horizontal fonts are allowed; otherwise, <strong>false</strong>. The default value is <strong>true</strong>.
    /// </value>
    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Controls whether vertical fonts can be selected.")]
    public bool AllowVerticalFonts { get; set; }

    /// <summary>
    /// Gets or sets the selected font color.
    /// </summary>
    /// <value>
    /// The color of the selected font. The default value is Black.
    /// </value>
    [DefaultValue(typeof(Color), "Black")]
    [Category("Data")]
    [Description("The color selected in the dialog box.")]
    public Color Color { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box allows only the selection of fixed-pitch fonts.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if only fixed-pitch fonts can be selected; otherwise, <strong>false</strong>. The default value is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether only fixed pitch fonts can be selected.")]
    public bool FixedPitchOnly { get; set; }

    /// <summary>
    /// Gets or sets the selected font.
    /// </summary>
    /// <value>
    /// The selected font.
    /// </value>
    [Category("Data")]
    [Description("The font selected in the dialog box.")]
    public Font Font
    {
      get
      {
        Font font;
        float fontSize;
        int minSize;
        int maxSize;

        font = _font ?? SystemFonts.DefaultFont;

        fontSize = font.SizeInPoints;

        // clamp the font to the minimum size if set
        minSize = this.MinSize;
        if (minSize > 0 && fontSize < minSize)
        {
          font = new Font(font.FontFamily, minSize, font.Style, GraphicsUnit.Point);
        }

        // clamp the font to the maximum size if set
        maxSize = this.MaxSize;
        if (maxSize > 0 && fontSize > maxSize)
        {
          font = new Font(font.FontFamily, maxSize, font.Style, GraphicsUnit.Point);
        }

        return font;
      }
      set { _font = value; }
    }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box specifies an error condition if the user attempts to select a font or style that does not exist.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the dialog box specifies an error condition when the user tries to select a font or style that does not exist; otherwise, <strong>false</strong>. The default is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether to report an error if the selected font does not exist.")]
    public bool FontMustExist { get; set; }

    /// <summary>
    /// Gets or sets the maximum point size a user can select.
    /// </summary>
    /// <value>
    /// The maximum point size a user can select. The default is 0.
    /// </value>
    [DefaultValue(0)]
    [Category("Data")]
    [Description("The maximum point size that can be selected (or zero to disable).")]
    public int MaxSize
    {
      get { return _maxSize; }
      set
      {
        if (value < 0)
        {
          value = 0;
        }

        _maxSize = value;

        if (_maxSize > 0 && _maxSize < _minSize)
        {
          _minSize = _maxSize;
        }
      }
    }

    /// <summary>
    /// Gets or sets the minimum point size a user can select.
    /// </summary>
    /// <value>
    /// The minimum point size a user can select. The default is 0.
    /// </value>
    [DefaultValue(0)]
    [Category("Data")]
    [Description("The minimum point size that can be Selected (or zero to disable).")]
    public int MinSize
    {
      get { return _minSize; }
      set
      {
        if (value < 0)
        {
          value = 0;
        }

        _minSize = value;

        if (_maxSize > 0 && _maxSize < _minSize)
        {
          _maxSize = _minSize;
        }
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box allows selection of fonts for all non-OEM and Symbol character sets, as well as the ANSI character set.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if selection of fonts for all non-OEM and Symbol character sets, as well as the ANSI character set, is allowed; otherwise, <strong>false</strong>. The default value is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether to exclude OEM and Symbol character sets.")]
    public bool ScriptsOnly { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box contains an <strong>Apply</strong> button.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the dialog box contains an <strong>Apply</strong> button; otherwise, <strong>false</strong>. The default value is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether to show the Apply button.")]
    public bool ShowApply { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box displays the color choice.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the dialog box displays the color choice; otherwise, <strong>false</strong>. The default value is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether to show a color choice.")]
    public bool ShowColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box contains controls that allow the user to specify strikethrough, underline, and text color options.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the dialog box contains controls to set strikethrough, underline, and text color options; otherwise, <strong>false</strong>. The default value is <strong>true</strong>.
    /// </value>
    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Controls whether to show the underline, strikeout, and font color selections.")]
    public bool ShowEffects { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the dialog box displays a <strong>Help</strong> button.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if the dialog box displays a <strong>Help</strong> button; otherwise, <strong>false</strong>. The default value is <strong>false</strong>.
    /// </value>
    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether to show the Help button.")]
    public bool ShowHelp { get; set; }

    #endregion

    #region Methods

    /// <summary>
    /// When overridden in a derived class, resets the properties of a common dialog box to their default values.
    /// </summary>
    public override void Reset()
    {
      this.Color = Color.Black;
      this.AllowScriptChange = true;
      this.AllowSimulations = true;
      this.AllowVectorFonts = true;
      this.AllowVerticalFonts = true;
      this.ShowColor = false;
      this.FontMustExist = false;
      this.FixedPitchOnly = false;
      this.MaxSize = 0;
      this.MaxSize = 0;
      this.Font = null;
      this.ShowApply = false;
      this.ShowHelp = false;
      this.ShowEffects = true;
    }

    /// <summary>
    /// Retrieves a string that includes the name of the current font selected in the dialog box.
    /// </summary>
    public override string ToString()
    {
      return string.Concat(base.ToString(), ",  Font: ", this.Font.ToString());
    }

    /// <summary>
    /// Defines the common dialog box hook procedure that is overridden to add specific functionality to a common dialog box.
    /// </summary>
    /// <returns>
    /// A zero value if the default dialog box procedure processes the message; a nonzero value if the default dialog box procedure ignores the message.
    /// </returns>
    /// <param name="hWnd">The handle to the dialog box window. </param><param name="msg">The message being received. </param><param name="wparam">Additional information about the message. </param><param name="lparam">Additional information about the message. </param>
    protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam)
    {
      // This code is lifted directly from System.Windows.Forms.FontDialog

      switch (msg)
      {
        case NativeMethods.WM_COMMAND:
          if ((int)wparam == 0x402)
          {
            NativeMethods.LOGFONT lf = new NativeMethods.LOGFONT();
            NativeMethods.SendMessage(new HandleRef(null, hWnd), NativeMethods.WM_CHOOSEFONT_GETLOGFONT, 0, lf);
            this.UpdateFont(lf);
            int index = (int)NativeMethods.SendDlgItemMessage(new HandleRef(null, hWnd), 0x473, NativeMethods.CB_GETCURSEL, IntPtr.Zero, IntPtr.Zero);
            if (index != NativeMethods.CB_ERR)
            {
              this.UpdateColor((int)NativeMethods.SendDlgItemMessage(new HandleRef(null, hWnd), 0x473, NativeMethods.CB_GETITEMDATA, (IntPtr)index, IntPtr.Zero));
            }

            try
            {
              this.OnApply(EventArgs.Empty);
            }
            catch (Exception e)
            {
              Application.OnThreadException(e);
            }
          }
          break;
        case NativeMethods.WM_INITDIALOG:
          if (!this.ShowColor)
          {
            IntPtr hWndCtl = NativeMethods.GetDlgItem(new HandleRef(null, hWnd), NativeMethods.cmb4);
            NativeMethods.ShowWindow(new HandleRef(null, hWndCtl), NativeMethods.SW_HIDE);
            hWndCtl = NativeMethods.GetDlgItem(new HandleRef(null, hWnd), NativeMethods.stc4);
            NativeMethods.ShowWindow(new HandleRef(null, hWndCtl), NativeMethods.SW_HIDE);
          }
          break;
      }

      return base.HookProc(hWnd, msg, wparam, lparam);
    }

    /// <summary>
    /// Raises the <see cref="Apply" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnApply(EventArgs e)
    {
      EventHandler handler;

      handler = this.Apply;

      if (handler != null)
      {
        handler(this, e);
      }
    }

    /// <summary>
    /// When overridden in a derived class, specifies a common dialog box.
    /// </summary>
    /// <returns>
    /// true if the dialog box was successfully run; otherwise, false.
    /// </returns>
    /// <param name="hwndOwner">A value that represents the window handle of the owner window for the common dialog box. </param>
    protected override bool RunDialog(IntPtr hwndOwner)
    {
      NativeMethods.LOGFONT lf;
      NativeMethods.CHOOSEFONT cf;
      IntPtr plf;
      bool result;
      int minSize;
      int maxSize;
      bool showColor;

      lf = new NativeMethods.LOGFONT();

      this.Font.ToLogFont(lf);

      plf = Marshal.AllocHGlobal(Marshal.SizeOf(lf));
      Marshal.StructureToPtr(lf, plf, false);

      showColor = this.ShowColor || this.ShowEffects;

      cf = new NativeMethods.CHOOSEFONT();
      cf.lStructSize = Marshal.SizeOf(typeof(NativeMethods.CHOOSEFONT));
      cf.Flags = this.GetFlags();
      cf.hwndOwner = hwndOwner;
      cf.lpfnHook = this.HookProc;

      minSize = this.MinSize;
      maxSize = this.MaxSize;
      if (minSize > 0 || maxSize > 0)
      {
        cf.nSizeMin = minSize;
        cf.nSizeMax = maxSize > 0 ? maxSize : int.MaxValue;
      }

      cf.rgbColors = ColorTranslator.ToWin32(showColor ? this.Color : Color.Black);

      cf.lpLogFont = plf;

      try
      {
        result = NativeMethods.ChooseFont(ref cf);

        if (result)
        {
          // create a managed font from the updated LOGFONT
          lf = (NativeMethods.LOGFONT)Marshal.PtrToStructure(plf, typeof(NativeMethods.LOGFONT));
          if (!string.IsNullOrEmpty(lf.lfFaceName))
          {
            this.UpdateFont(lf);
          }

          // and update the color
          if (showColor)
          {
            this.UpdateColor(cf.rgbColors);
          }
        }
      }
      finally
      {
        // always be freein' allocated memory!
        Marshal.FreeHGlobal(plf);
      }

      return result;
    }

    /// <summary>
    /// Gets the flags to apply to the CHOOSEFONT structure
    /// </summary>
    private int GetFlags()
    {
      NativeMethods.CHOOSEFONTFLAGS flags;

      flags = NativeMethods.CHOOSEFONTFLAGS.CF_INITTOLOGFONTSTRUCT | NativeMethods.CHOOSEFONTFLAGS.CF_TTONLY | NativeMethods.CHOOSEFONTFLAGS.CF_ENABLEHOOK;

      if (this.ShowApply)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_APPLY;
      }

      if (this.ShowEffects)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_EFFECTS;
      }

      if (this.FixedPitchOnly)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_FIXEDPITCHONLY;
      }

      if (this.FontMustExist)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_FORCEFONTEXIST;
      }

      if (this.MinSize != 0 || this.MaxSize != 0)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_LIMITSIZE;
      }

      if (!this.AllowScriptChange)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_NOSCRIPTSEL;
      }

      if (!this.AllowSimulations)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_NOSIMULATIONS;
      }

      if (!this.AllowVectorFonts)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_NOVERTFONTS;
      }

      if (this.ScriptsOnly)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_SCRIPTSONLY;
        ;
      }

      if (this.ShowHelp)
      {
        flags |= NativeMethods.CHOOSEFONTFLAGS.CF_SHOWHELP;
      }

      return (int)flags;
    }

    /// <summary>
    /// Resets the font.
    /// </summary>
    private void ResetFont()
    {
      this.Font = null;
    }

    /// <summary>
    /// Determine if we should serialize font.
    /// </summary>
    /// <returns>
    /// true if it succeeds, false if it fails.
    /// </returns>
    private bool ShouldSerializeFont()
    {
      return !this.Font.Equals(Control.DefaultFont);
    }

    /// <summary>
    /// Updates the color
    /// </summary>
    /// <param name="rgb">  The OLE color value. </param>
    private void UpdateColor(int rgb)
    {
      if (ColorTranslator.ToWin32(this.Color) != rgb)
      {
        this.Color = ColorTranslator.FromOle(rgb);
      }
    }

    /// <summary>
    /// Updates the font described by the specified LOGFONT structure
    /// </summary>
    /// <param name="lf"> The source font. </param>
    private void UpdateFont(NativeMethods.LOGFONT lf)
    {
      Font font;

      try
      {
        // This one line is the whole point of having to write this class as it can
        // throw an exception, which System.Windows.Forms.FontDialog doesn't handle

        font = Font.FromLogFont(lf);
      }
      catch
      {
        font = null;
      }

      if (font != null)
      {
        this.Font = font;
      }
    }

    #endregion
  }
}
