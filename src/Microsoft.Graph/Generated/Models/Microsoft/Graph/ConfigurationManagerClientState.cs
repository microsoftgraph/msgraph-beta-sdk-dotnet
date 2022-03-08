namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum ConfigurationManagerClientState {
        Unknown,
        Installed,
        Healthy,
        InstallFailed,
        UpdateFailed,
        CommunicationError,
    }
}
