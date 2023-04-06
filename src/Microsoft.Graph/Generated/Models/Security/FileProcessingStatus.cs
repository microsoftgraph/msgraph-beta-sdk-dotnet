using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum FileProcessingStatus {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "internalError")]
        InternalError,
        [EnumMember(Value = "unknownError")]
        UnknownError,
        [EnumMember(Value = "processingTimeout")]
        ProcessingTimeout,
        [EnumMember(Value = "invalidFileId")]
        InvalidFileId,
        [EnumMember(Value = "fileSizeIsZero")]
        FileSizeIsZero,
        [EnumMember(Value = "fileSizeIsTooLarge")]
        FileSizeIsTooLarge,
        [EnumMember(Value = "fileDepthLimitExceeded")]
        FileDepthLimitExceeded,
        [EnumMember(Value = "fileBodyIsTooLong")]
        FileBodyIsTooLong,
        [EnumMember(Value = "fileTypeIsUnknown")]
        FileTypeIsUnknown,
        [EnumMember(Value = "fileTypeIsNotSupported")]
        FileTypeIsNotSupported,
        [EnumMember(Value = "malformedFile")]
        MalformedFile,
        [EnumMember(Value = "protectedFile")]
        ProtectedFile,
        [EnumMember(Value = "poisonFile")]
        PoisonFile,
        [EnumMember(Value = "noReviewSetSummaryGenerated")]
        NoReviewSetSummaryGenerated,
        [EnumMember(Value = "extractionException")]
        ExtractionException,
        [EnumMember(Value = "ocrProcessingTimeout")]
        OcrProcessingTimeout,
        [EnumMember(Value = "ocrFileSizeExceedsLimit")]
        OcrFileSizeExceedsLimit,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
