﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using WInterop.Extensions.WindowExtensions;
using WInterop.Gdi.Types;
using WInterop.Modules.Types;
using WInterop.Resources.Types;
using WInterop.Windows;
using WInterop.Windows.Types;

namespace AltWind
{
    /// <summary>
    /// Sample from Programming Windows, 5th Edition.
    /// Original (c) Charles Petzold, 1998
    /// Figure 5-21, Pages 171-173.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ModuleInstance module = Marshal.GetHINSTANCE(typeof(Program).Module);
            WindowClass wndclass = new WindowClass
            {
                Style = ClassStyle.HorizontalRedraw | ClassStyle.VerticalRedraw,
                WindowProcedure = WindowProcedure,
                Instance = module,
                Icon = IconId.Application,
                Cursor = CursorId.Arrow,
                Background = StockBrush.White,
                ClassName = "AltWind"
            };

            Windows.RegisterClass(ref wndclass);

            WindowHandle window = Windows.CreateWindow(
                module,
                "AltWind",
                "Alternate and Winding Fill Modes",
                WindowStyles.OverlappedWindow);

            window.ShowWindow(ShowWindow.Normal);
            window.UpdateWindow();

            while (Windows.GetMessage(out MSG message))
            {
                Windows.TranslateMessage(ref message);
                Windows.DispatchMessage(ref message);
            }
        }

        static POINT[] aptFigure =
        {
            new POINT(10, 70),
            new POINT(50, 70),
            new POINT(50, 10),
            new POINT(90, 10),
            new POINT(90, 50),
            new POINT(30, 50),
            new POINT(30, 90),
            new POINT(70, 90),
            new POINT(70, 30),
            new POINT(10, 30)
        };

        static int cxClient, cyClient;

        static LRESULT WindowProcedure(WindowHandle window, WindowMessage message, WPARAM wParam, LPARAM lParam)
        {
            switch (message)
            {
                case WindowMessage.Size:
                    cxClient = lParam.LowWord;
                    cyClient = lParam.HighWord;
                    return 0;
                case WindowMessage.Paint:
                    POINT[] apt = new POINT[10];
                    using (DeviceContext dc = window.BeginPaint())
                    {
                        dc.SelectObject(StockBrush.Gray);
                        for (int i = 0; i < 10; i++)
                        {
                            apt[i].x = cxClient * aptFigure[i].x / 200;
                            apt[i].y = cyClient * aptFigure[i].y / 100;
                        }

                        dc.SetPolyFillMode(PolyFillMode.Alternate);
                        dc.Polygon(apt);

                        for (int i = 0; i < 10; i++)
                        {
                            apt[i].x += cxClient / 2;
                        }
                        dc.SetPolyFillMode(PolyFillMode.Winding);
                        dc.Polygon(apt);
                    }

                    return 0;
                case WindowMessage.Destroy:
                    Windows.PostQuitMessage(0);
                    return 0;
            }

            return Windows.DefaultWindowProcedure(window, message, wParam, lParam);
        }
    }
}
