﻿using System.Runtime.InteropServices;

namespace System;

internal static partial class NativeMethods
{
    [DllImport("user32.dll")]
    internal static extern bool GetComboBoxInfo(nint hWnd, ref COMBOBOXINFO pcbi);
}
