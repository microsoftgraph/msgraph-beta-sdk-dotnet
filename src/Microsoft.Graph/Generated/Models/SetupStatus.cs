namespace Microsoft.Graph.Beta.Models {
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
