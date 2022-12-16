namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum EducationSynchronizationStatus {
        Paused,
        InProgress,
        Success,
        Error,
        ValidationError,
        Quarantined,
        UnknownFutureValue,
        Extracting,
        Validating,
    }
}
