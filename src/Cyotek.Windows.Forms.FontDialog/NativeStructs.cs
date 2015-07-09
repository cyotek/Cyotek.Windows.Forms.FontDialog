/* Cyotek FontDialog
 * http://cyotek.com
 * http://cyotek.com/blog/tag/fontdialog
 *
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE.txt for the full text.
 */

using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

// http://www.pinvoke.net/default.aspx/comdlg32.choosefont

namespace Cyotek.Windows.Forms
{
  internal static partial class NativeMethods
  {
    #region Nested type: CHOOSEFONT

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct CHOOSEFONT
    {
      public int lStructSize;

      public IntPtr hwndOwner; // caller's window handle

      public IntPtr hDC; // printer DC/IC or NULL

      public IntPtr lpLogFont; // ptr. to a LOGFONT struct

      public int iPointSize; // 10 * size in points of selected font

      public int Flags; // enum. type flags

      public int rgbColors; // returned text color

      public IntPtr lCustData; // data passed to hook fn.

      public WndProc lpfnHook; // ptr. to hook function

      public string lpTemplateName; // custom template name

      public IntPtr hInstance; // instance handle of.EXE that

      //   contains cust. dlg. template
      public string lpszStyle; // return the style field here

      // must be LF_FACESIZE or bigger
      public short nFontType; // same value reported to the EnumFonts

      //   call back with the extra FONTTYPE_
      //   bits added
      private readonly short __MISSING_ALIGNMENT__; // minimum pt size allowed &

      public int nSizeMin; // max pt size allowed if

      public int nSizeMax; //   CF_LIMITSIZE is used
    }

    #endregion

    #region Nested type: LOGFONT

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class LOGFONT
    {
      public int lfHeight;

      public int lfWidth;

      public int lfEscapement;

      public int lfOrientation;

      public int lfWeight;

      public byte lfItalic;

      public byte lfUnderline;

      public byte lfStrikeOut;

      public byte lfCharSet;

      public byte lfOutPrecision;

      public byte lfClipPrecision;

      public byte lfQuality;

      public byte lfPitchAndFamily;

      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string lfFaceName;
    }

    #endregion
  }
}
