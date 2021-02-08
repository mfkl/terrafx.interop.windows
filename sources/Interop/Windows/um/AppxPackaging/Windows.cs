// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IAppxFactory = new Guid(0xBEB94909, 0xE451, 0x438B, 0xB5, 0xA7, 0xD7, 0x9E, 0x76, 0x7B, 0x75, 0xD8);

        public static readonly Guid IID_IAppxFactory2 = new Guid(0xF1346DF2, 0xC282, 0x4E22, 0xB9, 0x18, 0x74, 0x3A, 0x92, 0x9A, 0x8D, 0x55);

        public static readonly Guid IID_IAppxPackageReader = new Guid(0xB5C49650, 0x99BC, 0x481C, 0x9A, 0x34, 0x3D, 0x53, 0xA4, 0x10, 0x67, 0x08);

        public static readonly Guid IID_IAppxPackageWriter = new Guid(0x9099E33B, 0x246F, 0x41E4, 0x88, 0x1A, 0x00, 0x8E, 0xB6, 0x13, 0xF8, 0x58);

        public static readonly Guid IID_IAppxPackageWriter2 = new Guid(0x2CF5C4FD, 0xE54C, 0x4EA5, 0xBA, 0x4E, 0xF8, 0xC4, 0xB1, 0x05, 0xA8, 0xC8);

        public static readonly Guid IID_IAppxPackageWriter3 = new Guid(0xA83AACD3, 0x41C0, 0x4501, 0xB8, 0xA3, 0x74, 0x16, 0x4F, 0x50, 0xB2, 0xFD);

        public static readonly Guid IID_IAppxFile = new Guid(0x91DF827B, 0x94FD, 0x468F, 0x82, 0x7B, 0x57, 0xF4, 0x1B, 0x2F, 0x6F, 0x2E);

        public static readonly Guid IID_IAppxFilesEnumerator = new Guid(0xF007EEAF, 0x9831, 0x411C, 0x98, 0x47, 0x91, 0x7C, 0xDC, 0x62, 0xD1, 0xFE);

        public static readonly Guid IID_IAppxBlockMapReader = new Guid(0x5EFEC991, 0xBCA3, 0x42D1, 0x9E, 0xC2, 0xE9, 0x2D, 0x60, 0x9E, 0xC2, 0x2A);

        public static readonly Guid IID_IAppxBlockMapFile = new Guid(0x277672AC, 0x4F63, 0x42C1, 0x8A, 0xBC, 0xBE, 0xAE, 0x36, 0x00, 0xEB, 0x59);

        public static readonly Guid IID_IAppxBlockMapFilesEnumerator = new Guid(0x02B856A2, 0x4262, 0x4070, 0xBA, 0xCB, 0x1A, 0x8C, 0xBB, 0xC4, 0x23, 0x05);

        public static readonly Guid IID_IAppxBlockMapBlock = new Guid(0x75CF3930, 0x3244, 0x4FE0, 0xA8, 0xC8, 0xE0, 0xBC, 0xB2, 0x70, 0xB8, 0x89);

        public static readonly Guid IID_IAppxBlockMapBlocksEnumerator = new Guid(0x6B429B5B, 0x36EF, 0x479E, 0xB9, 0xEB, 0x0C, 0x14, 0x82, 0xB4, 0x9E, 0x16);

        public static readonly Guid IID_IAppxManifestReader = new Guid(0x4E1BD148, 0x55A0, 0x4480, 0xA3, 0xD1, 0x15, 0x54, 0x47, 0x10, 0x63, 0x7C);

        public static readonly Guid IID_IAppxManifestReader2 = new Guid(0xD06F67BC, 0xB31D, 0x4EBA, 0xA8, 0xAF, 0x63, 0x8E, 0x73, 0xE7, 0x7B, 0x4D);

        public static readonly Guid IID_IAppxManifestReader3 = new Guid(0xC43825AB, 0x69B7, 0x400A, 0x97, 0x09, 0xCC, 0x37, 0xF5, 0xA7, 0x2D, 0x24);

        public static readonly Guid IID_IAppxManifestReader4 = new Guid(0x4579BB7C, 0x741D, 0x4161, 0xB5, 0xA1, 0x47, 0xBD, 0x3B, 0x78, 0xAD, 0x9B);

        public static readonly Guid IID_IAppxManifestReader5 = new Guid(0x8D7AE132, 0xA690, 0x4C00, 0xB7, 0x5A, 0x6A, 0xAE, 0x1F, 0xEA, 0xAC, 0x80);

        public static readonly Guid IID_IAppxManifestReader6 = new Guid(0x34DEACA4, 0xD3C0, 0x4E3E, 0xB3, 0x12, 0xE4, 0x26, 0x25, 0xE3, 0x80, 0x7E);

        public static readonly Guid IID_IAppxManifestReader7 = new Guid(0x8EFE6F27, 0x0CE0, 0x4988, 0xB3, 0x2D, 0x73, 0x8E, 0xB6, 0x3D, 0xB3, 0xB7);

        public static readonly Guid IID_IAppxManifestDriverDependenciesEnumerator = new Guid(0xFE039DB2, 0x467F, 0x4755, 0x84, 0x04, 0x8F, 0x5E, 0xB6, 0x86, 0x5B, 0x33);

        public static readonly Guid IID_IAppxManifestDriverDependency = new Guid(0x1210CB94, 0x5A92, 0x4602, 0xBE, 0x24, 0x79, 0xF3, 0x18, 0xAF, 0x4A, 0xF9);

        public static readonly Guid IID_IAppxManifestDriverConstraintsEnumerator = new Guid(0xD402B2D1, 0xF600, 0x49E0, 0x95, 0xE6, 0x97, 0x5D, 0x8D, 0xA1, 0x3D, 0x89);

        public static readonly Guid IID_IAppxManifestDriverConstraint = new Guid(0xC031BEE4, 0xBBCC, 0x48EA, 0xA2, 0x37, 0xC3, 0x40, 0x45, 0xC8, 0x0A, 0x07);

        public static readonly Guid IID_IAppxManifestOSPackageDependenciesEnumerator = new Guid(0xB84E2FC3, 0xF8EC, 0x4BC1, 0x8A, 0xE2, 0x15, 0x63, 0x46, 0xF5, 0xFF, 0xEA);

        public static readonly Guid IID_IAppxManifestOSPackageDependency = new Guid(0x154995EE, 0x54A6, 0x4F14, 0xAC, 0x97, 0xD8, 0xCF, 0x05, 0x19, 0x64, 0x4B);

        public static readonly Guid IID_IAppxManifestHostRuntimeDependenciesEnumerator = new Guid(0x6427A646, 0x7F49, 0x433E, 0xB1, 0xA6, 0x0D, 0xA3, 0x09, 0xF6, 0x88, 0x5A);

        public static readonly Guid IID_IAppxManifestHostRuntimeDependency = new Guid(0x3455D234, 0x8414, 0x410D, 0x95, 0xC7, 0x7B, 0x35, 0x25, 0x5B, 0x83, 0x91);

        public static readonly Guid IID_IAppxManifestOptionalPackageInfo = new Guid(0x2634847D, 0x5B5D, 0x4FE5, 0xA2, 0x43, 0x00, 0x2F, 0xF9, 0x5E, 0xDC, 0x7E);

        public static readonly Guid IID_IAppxManifestMainPackageDependenciesEnumerator = new Guid(0xA99C4F00, 0x51D2, 0x4F0F, 0xBA, 0x46, 0x7E, 0xD5, 0x25, 0x5E, 0xBD, 0xFF);

        public static readonly Guid IID_IAppxManifestMainPackageDependency = new Guid(0x05D0611C, 0xBC29, 0x46D5, 0x97, 0xE2, 0x84, 0xB9, 0xC7, 0x9B, 0xD8, 0xAE);

        public static readonly Guid IID_IAppxManifestPackageId = new Guid(0x283CE2D7, 0x7153, 0x4A91, 0x96, 0x49, 0x7A, 0x0F, 0x72, 0x40, 0x94, 0x5F);

        public static readonly Guid IID_IAppxManifestPackageId2 = new Guid(0x2256999D, 0xD617, 0x42F1, 0x88, 0x0E, 0x0B, 0xA4, 0x54, 0x23, 0x19, 0xD5);

        public static readonly Guid IID_IAppxManifestProperties = new Guid(0x03FAF64D, 0xF26F, 0x4B2C, 0xAA, 0xF7, 0x8F, 0xE7, 0x78, 0x9B, 0x8B, 0xCA);

        public static readonly Guid IID_IAppxManifestTargetDeviceFamiliesEnumerator = new Guid(0x36537F36, 0x27A4, 0x4788, 0x88, 0xC0, 0x73, 0x38, 0x19, 0x57, 0x50, 0x17);

        public static readonly Guid IID_IAppxManifestTargetDeviceFamily = new Guid(0x9091B09B, 0xC8D5, 0x4F31, 0x86, 0x87, 0xA3, 0x38, 0x25, 0x9F, 0xAE, 0xFB);

        public static readonly Guid IID_IAppxManifestPackageDependenciesEnumerator = new Guid(0xB43BBCF9, 0x65A6, 0x42DD, 0xBA, 0xC0, 0x8C, 0x67, 0x41, 0xE7, 0xF5, 0xA4);

        public static readonly Guid IID_IAppxManifestPackageDependency = new Guid(0xE4946B59, 0x733E, 0x43F0, 0xA7, 0x24, 0x3B, 0xDE, 0x4C, 0x12, 0x85, 0xA0);

        public static readonly Guid IID_IAppxManifestPackageDependency2 = new Guid(0xDDA0B713, 0xF3FF, 0x49D3, 0x89, 0x8A, 0x27, 0x86, 0x78, 0x0C, 0x5D, 0x98);

        public static readonly Guid IID_IAppxManifestPackageDependency3 = new Guid(0x1AC56374, 0x6198, 0x4D6B, 0x92, 0xE4, 0x74, 0x9D, 0x5A, 0xB8, 0xA8, 0x95);

        public static readonly Guid IID_IAppxManifestResourcesEnumerator = new Guid(0xDE4DFBBD, 0x881A, 0x48BB, 0x85, 0x8C, 0xD6, 0xF2, 0xBA, 0xEA, 0xE6, 0xED);

        public static readonly Guid IID_IAppxManifestDeviceCapabilitiesEnumerator = new Guid(0x30204541, 0x427B, 0x4A1C, 0xBA, 0xCF, 0x65, 0x5B, 0xF4, 0x63, 0xA5, 0x40);

        public static readonly Guid IID_IAppxManifestCapabilitiesEnumerator = new Guid(0x11D22258, 0xF470, 0x42C1, 0xB2, 0x91, 0x83, 0x61, 0xC5, 0x43, 0x7E, 0x41);

        public static readonly Guid IID_IAppxManifestApplicationsEnumerator = new Guid(0x9EB8A55A, 0xF04B, 0x4D0D, 0x80, 0x8D, 0x68, 0x61, 0x85, 0xD4, 0x84, 0x7A);

        public static readonly Guid IID_IAppxManifestApplication = new Guid(0x5DA89BF4, 0x3773, 0x46BE, 0xB6, 0x50, 0x7E, 0x74, 0x48, 0x63, 0xB7, 0xE8);

        public static readonly Guid IID_IAppxManifestQualifiedResourcesEnumerator = new Guid(0x8EF6ADFE, 0x3762, 0x4A8F, 0x93, 0x73, 0x2F, 0xC5, 0xD4, 0x44, 0xC8, 0xD2);

        public static readonly Guid IID_IAppxManifestQualifiedResource = new Guid(0x3B53A497, 0x3C5C, 0x48D1, 0x9E, 0xA3, 0xBB, 0x7E, 0xAC, 0x8C, 0xD7, 0xD4);

        public static readonly Guid IID_IAppxBundleFactory = new Guid(0xBBA65864, 0x965F, 0x4A5F, 0x85, 0x5F, 0xF0, 0x74, 0xBD, 0xBF, 0x3A, 0x7B);

        public static readonly Guid IID_IAppxBundleWriter = new Guid(0xEC446FE8, 0xBFEC, 0x4C64, 0xAB, 0x4F, 0x49, 0xF0, 0x38, 0xF0, 0xC6, 0xD2);

        public static readonly Guid IID_IAppxBundleWriter2 = new Guid(0x6D8FE971, 0x01CC, 0x49A0, 0xB6, 0x85, 0x23, 0x38, 0x51, 0x27, 0x99, 0x62);

        public static readonly Guid IID_IAppxBundleWriter3 = new Guid(0xAD711152, 0xF969, 0x4193, 0x82, 0xD5, 0x9D, 0xDF, 0x27, 0x86, 0xD2, 0x1A);

        public static readonly Guid IID_IAppxBundleWriter4 = new Guid(0x9CD9D523, 0x5009, 0x4C01, 0x98, 0x82, 0xDC, 0x02, 0x9F, 0xBD, 0x47, 0xA3);

        public static readonly Guid IID_IAppxBundleReader = new Guid(0xDD75B8C0, 0xBA76, 0x43B0, 0xAE, 0x0F, 0x68, 0x65, 0x6A, 0x1D, 0xC5, 0xC8);

        public static readonly Guid IID_IAppxBundleManifestReader = new Guid(0xCF0EBBC1, 0xCC99, 0x4106, 0x91, 0xEB, 0xE6, 0x74, 0x62, 0xE0, 0x4F, 0xB0);

        public static readonly Guid IID_IAppxBundleManifestReader2 = new Guid(0x5517DF70, 0x033F, 0x4AF2, 0x82, 0x13, 0x87, 0xD7, 0x66, 0x80, 0x5C, 0x02);

        public static readonly Guid IID_IAppxBundleManifestPackageInfoEnumerator = new Guid(0xF9B856EE, 0x49A6, 0x4E19, 0xB2, 0xB0, 0x6A, 0x24, 0x06, 0xD6, 0x3A, 0x32);

        public static readonly Guid IID_IAppxBundleManifestPackageInfo = new Guid(0x54CD06C1, 0x268F, 0x40BB, 0x8E, 0xD2, 0x75, 0x7A, 0x9E, 0xBA, 0xEC, 0x8D);

        public static readonly Guid IID_IAppxBundleManifestPackageInfo2 = new Guid(0x44C2ACBC, 0xB2CF, 0x4CCB, 0xBB, 0xDB, 0x9C, 0x6D, 0xA8, 0xC3, 0xBC, 0x9E);

        public static readonly Guid IID_IAppxBundleManifestPackageInfo3 = new Guid(0x6BA74B98, 0xBB74, 0x4296, 0x80, 0xD0, 0x5F, 0x42, 0x56, 0xA9, 0x96, 0x75);

        public static readonly Guid IID_IAppxBundleManifestPackageInfo4 = new Guid(0x5DA6F13D, 0xA8A7, 0x4532, 0x85, 0x7C, 0x13, 0x93, 0xD6, 0x59, 0x37, 0x1D);

        public static readonly Guid IID_IAppxBundleManifestOptionalBundleInfoEnumerator = new Guid(0x9A178793, 0xF97E, 0x46AC, 0xAA, 0xCA, 0xDD, 0x5B, 0xA4, 0xC1, 0x77, 0xC8);

        public static readonly Guid IID_IAppxBundleManifestOptionalBundleInfo = new Guid(0x515BF2E8, 0xBCB0, 0x4D69, 0x8C, 0x48, 0xE3, 0x83, 0x14, 0x7B, 0x6E, 0x12);

        public static readonly Guid IID_IAppxContentGroupFilesEnumerator = new Guid(0x1A09A2FD, 0x7440, 0x44EB, 0x8C, 0x84, 0x84, 0x82, 0x05, 0xA6, 0xA1, 0xCC);

        public static readonly Guid IID_IAppxContentGroup = new Guid(0x328F6468, 0xC04F, 0x4E3C, 0xB6, 0xFA, 0x6B, 0x8D, 0x27, 0xF3, 0x00, 0x3A);

        public static readonly Guid IID_IAppxContentGroupsEnumerator = new Guid(0x3264E477, 0x16D1, 0x4D63, 0x82, 0x3E, 0x7D, 0x29, 0x84, 0x69, 0x66, 0x34);

        public static readonly Guid IID_IAppxContentGroupMapReader = new Guid(0x418726D8, 0xDD99, 0x4F5D, 0x98, 0x86, 0x15, 0x7A, 0xDD, 0x20, 0xDE, 0x01);

        public static readonly Guid IID_IAppxSourceContentGroupMapReader = new Guid(0xF329791D, 0x540B, 0x4A9F, 0xBC, 0x75, 0x32, 0x82, 0xB7, 0xD7, 0x31, 0x93);

        public static readonly Guid IID_IAppxContentGroupMapWriter = new Guid(0xD07AB776, 0xA9DE, 0x4798, 0x8C, 0x14, 0x3D, 0xB3, 0x1E, 0x68, 0x7C, 0x78);

        public static readonly Guid IID_IAppxPackagingDiagnosticEventSink = new Guid(0x17239D47, 0x6ADB, 0x45D2, 0x80, 0xF6, 0xF9, 0xCB, 0xC3, 0xBF, 0x05, 0x9D);

        public static readonly Guid IID_IAppxPackagingDiagnosticEventSinkManager = new Guid(0x369648FA, 0xA7EB, 0x4909, 0xA1, 0x5D, 0x69, 0x54, 0xA0, 0x78, 0xF1, 0x8A);

        public static readonly Guid IID_IAppxEncryptionFactory = new Guid(0x80E8E04D, 0x8C88, 0x44AE, 0xA0, 0x11, 0x7C, 0xAD, 0xF6, 0xFB, 0x2E, 0x72);

        public static readonly Guid IID_IAppxEncryptionFactory2 = new Guid(0xC1B11EEE, 0xC4BA, 0x4AB2, 0xA5, 0x5D, 0xD0, 0x15, 0xFE, 0x8F, 0xF6, 0x4F);

        public static readonly Guid IID_IAppxEncryptionFactory3 = new Guid(0x09EDCA37, 0xCD64, 0x47D6, 0xB7, 0xE8, 0x1C, 0xB1, 0x1D, 0x4F, 0x7E, 0x05);

        public static readonly Guid IID_IAppxEncryptionFactory4 = new Guid(0xA879611F, 0x12FD, 0x41FE, 0x85, 0xD5, 0x06, 0xAE, 0x77, 0x9B, 0xBA, 0xF5);

        public static readonly Guid IID_IAppxEncryptedPackageWriter = new Guid(0xF43D0B0B, 0x1379, 0x40E2, 0x9B, 0x29, 0x68, 0x2E, 0xA2, 0xBF, 0x42, 0xAF);

        public static readonly Guid IID_IAppxEncryptedPackageWriter2 = new Guid(0x3E475447, 0x3A25, 0x40B5, 0x8A, 0xD2, 0xF9, 0x53, 0xAE, 0x50, 0xC9, 0x2D);

        public static readonly Guid IID_IAppxEncryptedBundleWriter = new Guid(0x80B0902F, 0x7BF0, 0x4117, 0xB8, 0xC6, 0x42, 0x79, 0xEF, 0x81, 0xEE, 0x77);

        public static readonly Guid IID_IAppxEncryptedBundleWriter2 = new Guid(0xE644BE82, 0xF0FA, 0x42B8, 0xA9, 0x56, 0x8D, 0x1C, 0xB4, 0x8E, 0xE3, 0x79);

        public static readonly Guid IID_IAppxEncryptedBundleWriter3 = new Guid(0x0D34DEB3, 0x5CAE, 0x4DD3, 0x97, 0x7C, 0x50, 0x49, 0x32, 0xA5, 0x1D, 0x31);

        public static readonly Guid IID_IAppxPackageEditor = new Guid(0xE2ADB6DC, 0x5E71, 0x4416, 0x86, 0xB6, 0x86, 0xE5, 0xF5, 0x29, 0x1A, 0x6B);

        public static readonly Guid IID_AppxFactory = new Guid(0x5842A140, 0xFF9F, 0x4166, 0x8F, 0x5C, 0x62, 0xF5, 0xB7, 0xB0, 0xC7, 0x81);

        public static readonly Guid IID_AppxBundleFactory = new Guid(0x378E0446, 0x5384, 0x43B7, 0x88, 0x77, 0xE7, 0xDB, 0xDD, 0x88, 0x34, 0x46);

        public static readonly Guid IID_AppxPackagingDiagnosticEventSinkManager = new Guid(0x50CA0A46, 0x1588, 0x4161, 0x8E, 0xD2, 0xEF, 0x9E, 0x46, 0x9C, 0xED, 0x5D);

        public static readonly Guid IID_AppxEncryptionFactory = new Guid(0xDC664FDD, 0xD868, 0x46EE, 0x87, 0x80, 0x8D, 0x19, 0x6C, 0xB7, 0x39, 0xF7);

        public static readonly Guid IID_AppxPackageEditor = new Guid(0xF004F2CA, 0xAEBC, 0x4B0D, 0xBF, 0x58, 0xE5, 0x16, 0xD5, 0xBC, 0xC0, 0xAB);
    }
}