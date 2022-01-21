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

namespace Silk.NET.Direct3D9
{
    [Guid("fff32f81-d953-473a-9223-93d652aba93f")]
    [NativeName("Name", "IDirect3DCubeTexture9")]
    public unsafe partial struct IDirect3DCubeTexture9
    {
        public static readonly Guid Guid = new("fff32f81-d953-473a-9223-93d652aba93f");

        public static implicit operator IDirect3DBaseTexture9(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, IDirect3DBaseTexture9>(ref val);

        public static implicit operator IDirect3DResource9(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, IDirect3DResource9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DCubeTexture9
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
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetPriority(uint PriorityNew)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPriority()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PreLoad()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly Resourcetype GetType()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Resourcetype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Resourcetype>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetLOD(uint LODNew)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[11])(@this, LODNew);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[11])(@this, LODNew);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)LpVtbl[11])(@this, LODNew);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLOD()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLevelCount()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutoGenFilterType(Texturefiltertype FilterType)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, Texturefiltertype, int>)LpVtbl[14])(@this, FilterType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, Texturefiltertype, int>)LpVtbl[14])(@this, FilterType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype, int>)LpVtbl[14])(@this, FilterType);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Texturefiltertype GetAutoGenFilterType()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Texturefiltertype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMipSubLevels()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)LpVtbl[16])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLevelDesc(uint Level, SurfaceDesc* pDesc)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLevelDesc(uint Level, ref SurfaceDesc pDesc)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCubeMapSurface(CubemapFaces FaceType, uint Level, IDirect3DSurface9** ppCubeMapSurface)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCubeMapSurface(CubemapFaces FaceType, uint Level, ref IDirect3DSurface9* ppCubeMapSurface)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppCubeMapSurfacePtr = &ppCubeMapSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRect, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRect, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRect, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRectPtr, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRectPtr, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRectPtr, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedRect* pLockedRectPtr = &pLockedRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRect, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRect, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRect, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockRect(CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedRect* pLockedRectPtr = &pLockedRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRectPtr, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRectPtr, Flags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRectPtr, Flags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockRect(CubemapFaces FaceType, uint Level)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, uint, int>)LpVtbl[20])(@this, FaceType, Level);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, uint, int>)LpVtbl[20])(@this, FaceType, Level);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, int>)LpVtbl[20])(@this, FaceType, Level);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDirtyRect(CubemapFaces FaceType, Silk.NET.Maths.Rectangle<int>* pDirtyRect)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRect);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRect);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDirtyRect(CubemapFaces FaceType, ref Silk.NET.Maths.Rectangle<int> pDirtyRect)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectPtr = &pDirtyRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)LpVtbl[21])(@this, FaceType, pDirtyRectPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
