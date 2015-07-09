/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;

// ReSharper disable InconsistentNaming

namespace Cyotek.Windows.Forms
{
  internal static partial class NativeMethods
  {
    #region CHOOSEFONTFLAGS enum

    [Flags]
    public enum CHOOSEFONTFLAGS
    {
      CF_SCREENFONTS = 0x00000001,

      CF_PRINTERFONTS = 0x00000002,

      CF_BOTH = (CF_SCREENFONTS | CF_PRINTERFONTS),

      CF_SHOWHELP = 0x00000004,

      CF_ENABLEHOOK = 0x00000008,

      CF_ENABLETEMPLATE = 0x00000010,

      CF_ENABLETEMPLATEHANDLE = 0x00000020,

      CF_INITTOLOGFONTSTRUCT = 0x00000040,

      CF_USESTYLE = 0x00000080,

      CF_EFFECTS = 0x00000100,

      CF_APPLY = 0x00000200,

      CF_ANSIONLY = 0x00000400,

      CF_SCRIPTSONLY = CF_ANSIONLY,

      CF_NOVECTORFONTS = 0x00000800,

      CF_NOOEMFONTS = CF_NOVECTORFONTS,

      CF_NOSIMULATIONS = 0x00001000,

      CF_LIMITSIZE = 0x00002000,

      CF_FIXEDPITCHONLY = 0x00004000,

      CF_WYSIWYG = 0x00008000,

      CF_FORCEFONTEXIST = 0x00010000,

      CF_SCALABLEONLY = 0x00020000,

      CF_TTONLY = 0x00040000,

      CF_NOFACESEL = 0x00080000,

      CF_NOSTYLESEL = 0x00100000,

      CF_NOSIZESEL = 0x00200000,

      CF_SELECTSCRIPT = 0x00400000,

      CF_NOSCRIPTSEL = 0x00800000,

      CF_NOVERTFONTS = 0x01000000,

      CF_INACTIVEFONTS = 0x02000000
    }

    #endregion

    #region Constants

    public const int CB_ERR = (-1);

    public const int CB_GETCURSEL = 0x0147;

    public const int CB_GETITEMDATA = 0x0150;

    public const int cmb4 = 0x0473;

    public const int stc4 = 0x0443;

    public const int SW_HIDE = 0;

    public const int WM_CHOOSEFONT_GETLOGFONT = (WM_USER + 1);

    public const int WM_COMMAND = 0x0111;

    public const int WM_INITDIALOG = 0x0110;

    public const int WM_USER = 0x0400;

    #endregion
  }
}
