namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum PrintJobStateDetail {
        UploadPending,
        Transforming,
        CompletedSuccessfully,
        CompletedWithWarnings,
        CompletedWithErrors,
        ReleaseWait,
        Interpreting,
        UnknownFutureValue,
    }
}
