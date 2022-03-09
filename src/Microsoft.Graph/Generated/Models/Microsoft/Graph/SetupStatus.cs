namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of privilegedSignupStatus entities.</summary>
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
