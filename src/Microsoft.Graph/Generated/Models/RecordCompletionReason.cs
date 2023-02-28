namespace Microsoft.Graph.Beta.Models {
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
