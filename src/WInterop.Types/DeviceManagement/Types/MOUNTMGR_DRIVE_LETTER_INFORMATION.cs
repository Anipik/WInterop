﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.DeviceManagement.Types
{
    // https://msdn.microsoft.com/en-us/library/windows/hardware/ff562281.aspx
    public struct MOUNTMGR_DRIVE_LETTER_INFORMATION
    {
        public BOOLEAN DriveLetterWasAssigned;
        public UCHAR CurrentDriveLetter;
    }
}
