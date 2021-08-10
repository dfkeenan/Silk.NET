// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_EXPORT_FLAGS")]
    public enum ExportFlags : int
    {
        [NativeName("Name", "D3D12_EXPORT_FLAG_NONE")]
        ExportFlagNone = 0x0,
    }
}