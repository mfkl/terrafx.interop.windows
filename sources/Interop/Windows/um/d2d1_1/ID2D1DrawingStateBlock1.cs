// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    public unsafe partial struct ID2D1DrawingStateBlock1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1DrawingStateBlock1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetDescription([NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetDescription([NativeTypeName("D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[8]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* stdcall<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[9]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }
    }
}