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

namespace Cyotek.Windows.Forms
{
  internal static partial class NativeMethods
  {
    #region Externals

    [DllImport("comdlg32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool ChooseFont(ref CHOOSEFONT cf);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDlgItem(HandleRef hDlg, int nIDDlgItem);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string modName);

    [DllImport("user32.dll")]
    public static extern IntPtr SendDlgItemMessage(HandleRef hDlg, int nIDDlgItem, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, [In] [Out] LOGFONT lParam);

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(HandleRef hWnd, int nCmdShow);

    #endregion

    #region Delegates

    public delegate IntPtr WndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    #endregion
  }
}
