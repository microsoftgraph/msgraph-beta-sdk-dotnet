namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the cases property of the microsoft.graph.security entity.</summary>
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
