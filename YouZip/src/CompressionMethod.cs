﻿namespace YouZip;

public enum CompressionMethod
{
    TheFileIsStored = 0,
    TheFileIsShrunk = 1,
    TheFileIsCompressedFactor1 = 2,
    TheFileIsCompressedFactor2 = 3,
    TheFileIsCompressedFactor3 = 4,
    TheFileIsCompressedFactor4 = 5,
    TheFileIsImploded = 6,
    ReservedForTokenizingCompressionAlgorithm = 7,
    TheFileIsDeflated = 8,
    EnhanceDeflatingUsingDeflate64 = 9,
    PkwareDataCompressionLibraryImploding = 10,
    ReservedByPkware = 11,
    FileIsCompressedUsingBZip2 = 12,
    ReservedByPkware2 = 13,
    Lzma = 14,
    ReservedByPkware3 = 15,
    IbmZOsCmpscCompression = 16,
    ReservedByPkware4 = 17,
    FileIsCompressedUsingIbmTerse =  18,
    IbmLz77ZArchitecture  = 19,
    Deprecated = 20,
    ZstandardCompression = 93,
    Mp3Compression = 94,
    XzCompression = 95,
    JpegVariant  = 96,
    WavPackCompressedData = 97,
    PPMdVersionIRev1 = 98,
    AeXEncryptionMarker = 99
}