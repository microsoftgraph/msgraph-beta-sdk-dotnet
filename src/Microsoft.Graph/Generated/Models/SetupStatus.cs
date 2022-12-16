namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
