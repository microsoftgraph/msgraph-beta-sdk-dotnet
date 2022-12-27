namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
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
