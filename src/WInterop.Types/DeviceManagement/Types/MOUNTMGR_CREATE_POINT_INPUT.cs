﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.DeviceManagement.Types
{
    // https://msdn.microsoft.com/en-us/library/windows/hardware/ff562275.aspx
    public struct MOUNTMGR_CREATE_POINT_INPUT
    {
        public ushort SymbolicLinkNameOffset;
        public ushort SymbolicLinkNameLength;
        public ushort DeviceNameOffset;
        public ushort DeviceNameLength;
    }
}
