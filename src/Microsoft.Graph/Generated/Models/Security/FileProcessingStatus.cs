namespace Microsoft.Graph.Beta.Models.Security {
    public enum FileProcessingStatus {
        Success,
        InternalError,
        UnknownError,
        ProcessingTimeout,
        InvalidFileId,
        FileSizeIsZero,
        FileSizeIsTooLarge,
        FileDepthLimitExceeded,
        FileBodyIsTooLong,
        FileTypeIsUnknown,
        FileTypeIsNotSupported,
        MalformedFile,
        ProtectedFile,
        PoisonFile,
        NoReviewSetSummaryGenerated,
        ExtractionException,
        OcrProcessingTimeout,
        OcrFileSizeExceedsLimit,
        UnknownFutureValue,
    }
}
