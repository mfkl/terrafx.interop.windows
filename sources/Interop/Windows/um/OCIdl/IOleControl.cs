// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IOleControl
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleControl* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetControlInfo(IOleControl* pThis, [NativeTypeName("CONTROLINFO *")] CONTROLINFO* pCI);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnMnemonic(IOleControl* pThis, [NativeTypeName("MSG *")] MSG* pMsg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnAmbientPropertyChange(IOleControl* pThis, [NativeTypeName("DISPID")] int dispID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FreezeEvents(IOleControl* pThis, [NativeTypeName("BOOL")] int bFreeze);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetControlInfo([NativeTypeName("CONTROLINFO *")] CONTROLINFO* pCI)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetControlInfo>(lpVtbl->GetControlInfo)((IOleControl*)Unsafe.AsPointer(ref this), pCI);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnMnemonic([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnMnemonic>(lpVtbl->OnMnemonic)((IOleControl*)Unsafe.AsPointer(ref this), pMsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnAmbientPropertyChange([NativeTypeName("DISPID")] int dispID)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnAmbientPropertyChange>(lpVtbl->OnAmbientPropertyChange)((IOleControl*)Unsafe.AsPointer(ref this), dispID);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreezeEvents([NativeTypeName("BOOL")] int bFreeze)
        {
            return Marshal.GetDelegateForFunctionPointer<_FreezeEvents>(lpVtbl->FreezeEvents)((IOleControl*)Unsafe.AsPointer(ref this), bFreeze);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (CONTROLINFO *) __attribute__((stdcall))")]
            public IntPtr GetControlInfo;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public IntPtr OnMnemonic;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public IntPtr OnAmbientPropertyChange;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr FreezeEvents;
        }
    }
}
