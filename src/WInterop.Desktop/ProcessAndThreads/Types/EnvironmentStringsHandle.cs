﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using WInterop.Handles.Types;

namespace WInterop.ProcessAndThreads.Types
{
    /// <summary>
    /// Safe handle for a block of memory returned by GetEnvironmentStrings.
    /// </summary>
    public class EnvironmentStringsHandle : HandleZeroIsInvalid
    {
        public EnvironmentStringsHandle() : base(ownsHandle: true)
        {
        }

        protected override bool ReleaseHandle()
        {
            ProcessMethods.Imports.FreeEnvironmentStringsW(handle);
            handle = IntPtr.Zero;
            return true;
        }
    }
}
