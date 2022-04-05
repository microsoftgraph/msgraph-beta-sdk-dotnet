namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the record method.</summary>
    public enum RecordCompletionReason {
        OperationCanceled,
        StopToneDetected,
        MaxRecordDurationReached,
        InitialSilenceTimeout,
        MaxSilenceTimeout,
        PlayPromptFailed,
        PlayBeepFailed,
        MediaReceiveTimeout,
        UnspecifiedError,
    }
}
