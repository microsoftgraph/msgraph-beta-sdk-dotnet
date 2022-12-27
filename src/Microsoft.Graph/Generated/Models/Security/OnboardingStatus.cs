namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum OnboardingStatus {
        InsufficientInfo,
        Onboarded,
        CanBeOnboarded,
        Unsupported,
        UnknownFutureValue,
    }
}
