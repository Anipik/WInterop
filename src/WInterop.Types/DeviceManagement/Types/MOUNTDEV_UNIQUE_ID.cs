﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace WInterop.DeviceManagement.Types
{
    // https://msdn.microsoft.com/en-us/library/windows/hardware/ff562264.aspx
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MOUNTDEV_UNIQUE_ID
    {
        public ushort UniqueIdLength;
        private TrailingByte _UniqueId;
        public ReadOnlySpan<byte> UniqueId => _UniqueId.GetBuffer(UniqueIdLength);
    }
}
