﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace WInterop.Gdi.Types
{
    public class PenHandle : GdiObjectHandle
    {
        public PenHandle() : base() { }

        public PenHandle(IntPtr handle, bool ownsHandle = false) : base(handle, ownsHandle) { }

        static public implicit operator PenHandle(IntPtr handle)
        {
            return new PenHandle(handle);
        }
    }
}
