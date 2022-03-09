namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum ComplianceState {
        Unknown,
        Compliant,
        Noncompliant,
        Conflict,
        Error,
        InGracePeriod,
        ConfigManager,
    }
}
