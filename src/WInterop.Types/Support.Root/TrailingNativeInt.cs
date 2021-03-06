﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.CompilerServices;

namespace WInterop
{
    /// <summary>
    /// Used for trailing native unsized arrays of native ints. Native example:
    /// ULONG_PTR ProcessIdList[1];
    /// </summary>
    /// <remarks>
    /// Accessing the values is only safe when you have a pointer to the containing struct in
    /// a buffer. If you have an actual struct (Foo, not Foo*), the trailing array will have been
    /// truncated as the values aren't actually part of the struct.
    /// </remarks>
    public struct TrailingNativeInt
    {
        // NOTE: Ideally we'd make this generic, but we can't do that and be considered blittable by
        // C#. This prevents fixing or taking the address of types that contain this type.
        //
        // C# is considering a feature to tag structs as blittable and constrain on such which will
        // allow collapsing down to a single FOO_TYPE List[1] wrapper in theory.

        private UIntPtr _firstNativeInt;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ReadOnlySpan<UIntPtr> GetBuffer(uint sizeInBytes)
        {
            if (sizeInBytes == 0)
                return new ReadOnlySpan<UIntPtr>();

            fixed (UIntPtr* c = &_firstNativeInt)
                return new ReadOnlySpan<UIntPtr>(c, (int)(sizeInBytes / sizeof(UIntPtr)));
        }
    }
}
