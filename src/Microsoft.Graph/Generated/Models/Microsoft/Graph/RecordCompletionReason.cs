namespace MicrosoftGraph.Models.Microsoft.Graph {
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
