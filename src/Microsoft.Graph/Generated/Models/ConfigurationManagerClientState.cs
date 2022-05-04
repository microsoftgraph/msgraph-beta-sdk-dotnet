namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ConfigurationManagerClientState {
        Unknown,
        Installed,
        Healthy,
        InstallFailed,
        UpdateFailed,
        CommunicationError,
    }
}
