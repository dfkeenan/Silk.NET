// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("e913c351-783d-48ca-a1d1-4f306284ad56")]
    [NativeName("Name", "ID3D12ShaderReflectionType")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public static readonly Guid Guid = new("e913c351-783d-48ca-a1d1-4f306284ad56");

        public ID3D12ShaderReflectionType
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(ShaderTypeDesc* pDesc)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderTypeDesc pDesc)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderTypeDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this, Index);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[1])(@this, Index);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(byte* Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName(ref byte Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetMemberTypeByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)LpVtbl[2])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetMemberTypeName(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, byte*>)LpVtbl[3])(@this, Index);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)]
        public readonly string GetMemberTypeNameS(uint Index)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, string>)LpVtbl[3])(@this, Index);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsEqual(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pType);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[4])(@this, pTypePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetSubType()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetBaseClass()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaces()
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionType* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)LpVtbl[8])(@this, uIndex);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsOfType(ID3D12ShaderReflectionType* pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pType);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsOfType(ref ID3D12ShaderReflectionType pType)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[9])(@this, pTypePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBase);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ImplementsInterface(ref ID3D12ShaderReflectionType pBase)
        {
            var @this = (ID3D12ShaderReflectionType*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ShaderReflectionType* pBasePtr = &pBase)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)LpVtbl[10])(@this, pBasePtr);
                }
            #endif
            }
            return ret;
        }

    }
}
