﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using WInterop.Gdi.Types;
using WInterop.Modules.Types;
using WInterop.Resources.Types;
using WInterop.Windows.Types;

namespace WInterop.Resources
{
    public static partial class ResourceMethods
    {
        /// <summary>
        /// Direct usage of Imports isn't recommended. Use the wrappers that do the heavy lifting for you.
        /// </summary>
        public static partial class Imports
        {
            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms647486.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            unsafe public static extern int LoadStringW(
                SafeModuleHandle hInstance,
                int uID,
                out char* lpBuffer,
                int nBufferMax);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648402.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool GetCaretPos(
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648405.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool SetCaretPos(
                int X,
                int Y);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648406.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool ShowCaret(
                WindowHandle hWnd);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648403.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool HideCaret(
                WindowHandle hWnd);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648399.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool CreateCaret(
                WindowHandle hWnd,
                BitmapHandle hBitmap,
                int nWidth,
                int nHeight);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648400.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool DestroyCaret();

            // uint.MaxValue is INFINITE, or doesn't blink
            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648401.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern uint GetCaretBlinkTime();

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648404.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool SetCaretBlinkTime(
                uint uMSeconds);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648072.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern SharedIconHandle LoadIconW(
                SafeModuleHandle hInstance,
                IntPtr lpIconName);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648063.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool DestroyIcon(
                IntPtr hIcon);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648383.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static unsafe extern bool ClipCursor(
                RECT* lpRect);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648384.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern CursorHandle CopyCursor(
                CursorHandle pcur);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648385.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern CursorHandle CreateCursor(
                SafeModuleHandle hInst,
                int xHotSpot,
                int yHotSpot,
                int nWidth,
                int nHeight,
                byte[] pvANDPlane,
                byte[] pvXORPlane);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648386.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool DestroyCursor(
                IntPtr hCursor);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648387.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool GetClipCursor(
                out RECT lpRect);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648388.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern SharedCursorHandle GetCursor();

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648389.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool GetCursorInfo(
                ref CURSORINFO pci);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648390.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool GetCursorPos(
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/aa969464.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool GetPhysicalCursorPos(
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648391.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern SharedCursorHandle LoadCursorW(
                SafeModuleHandle hInstance,
                IntPtr lpCursorName);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648392.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern SharedCursorHandle LoadCursorFromFileW(
                IntPtr lpFileName);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648393.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern SharedCursorHandle SetCursor(
                CursorHandle hCursor);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648394.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool SetCursorPos(
                int X,
                int Y);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/aa969465.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool SetPhysicalCursorPos(
                int X,
                int Y);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648395.aspx
            [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
            public static extern bool SetSystemCursor(
                CursorHandle hcur,
                SystemCursor id);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/ms648396.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern int ShowCursor(
                bool bShow);
        }
    }
}
