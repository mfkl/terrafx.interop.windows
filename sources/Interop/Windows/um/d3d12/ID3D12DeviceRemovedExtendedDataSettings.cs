// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }
    }
}