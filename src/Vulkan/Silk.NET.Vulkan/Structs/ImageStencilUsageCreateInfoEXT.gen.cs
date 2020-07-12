// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageStencilUsageCreateInfoEXT")]
    public unsafe partial struct ImageStencilUsageCreateInfoEXT
    {
        public ImageStencilUsageCreateInfoEXT
        (
            StructureType sType = StructureType.ImageStencilUsageCreateInfo,
            void* pNext = default,
            ImageUsageFlags stencilUsage = default
        )
        {
            SType = sType;
            PNext = pNext;
            StencilUsage = stencilUsage;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "stencilUsage")]
        public ImageUsageFlags StencilUsage;
    }
}
