// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PLEX_READ_DATA_REQUEST
    {
        public LARGE_INTEGER ByteOffset;

        [NativeTypeName("DWORD")]
        public uint ByteLength;

        [NativeTypeName("DWORD")]
        public uint PlexNumber;
    }
}