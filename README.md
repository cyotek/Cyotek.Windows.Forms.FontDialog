# Cyotek FontDialog

Have you ever seen an exception like this?

    System.ArgumentException: Only TrueType fonts are supported. This is not a TrueType font.
      at System.Drawing.Font.FromLogFont(Object lf, IntPtr hdc)
      at System.Windows.Forms.FontDialog.UpdateFont(LOGFONT lf)
      at System.Windows.Forms.FontDialog.RunDialog(IntPtr hWndOwner)
      at System.Windows.Forms.CommonDialog.ShowDialog(IWin32Window owner)

This exception is thrown when using the `System.Windows.Forms.FontDialog` component and you select an invalid font. And you can't do a thing about it, as this exception is buried in a private method of the `FontDialog` and isn't handled. 

As the bug has been there for years without being fixed, and given that fact that Windows Forms isn't exactly high on the list of priorities for Microsoft, I suspect it will never be fixed. This is one wheel I'd prefer not to reinvent, but... here it is anyway.

> I haven't actually managed to find a font that causes this type of crash, although I have quite a few automated error reports from users who experience it. If you know of such a font that is available for download, please let me know so that I can test this myself. I assume my version fixes the problem but at this point I don't actually know for sure.

The `Cyotek.Windows.Forms.FontDialog` component is a drop in replacement for the original `System.Windows.Forms.FontDialog`, but without the crash that occurs when selecting a non-True Type font.

This version uses the native Win32 dialog via `ChooseFont` - the hook procedure to handle the `Apply` event and hiding the colour combobox has been taken directly from the original managed component.

There's also a fully managed solution buried in one of the branches of this repository. It is incomplete, mainly because I wasn't able to determine which fonts are hidden by settings, and how to combine families with non standard styles such as Light. It's still interesting in its own right, showing how to use `EnumFontFamiliesEx` etc, but for now it is on hold as a work in progress.

## NuGet Package

A NuGet package [is available](https://www.nuget.org/packages/Cyotek.Windows.Forms.FontDialog/1.0.0).

> PM> Install-Package Cyotek.Windows.Forms.FontDialog

## License

The `FontDialog` component is licensed under the MIT License. See `LICENSE.txt` for the full text.

## Further Reading

For more information on this control, see the [articles tagged with fontdialog](http://cyotek.com/blog/tag/fontdialog) at cyotek.com.
