namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum SetupStatus {
        Unknown,
        NotRegisteredYet,
        RegisteredSetupNotStarted,
        RegisteredSetupInProgress,
        RegistrationAndSetupCompleted,
        RegistrationFailed,
        RegistrationTimedOut,
        Disabled,
    }
}
