namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum ConfigurationManagerClientState {
        /// <summary>Configuration manager agent is older than 1806 or not installed or this device has not checked into Intune for over 30 days.</summary>
        Unknown,
        /// <summary>The configuration manager agent is installed but may not be showing up in the configuration manager console yet. Wait a few hours for it to refresh.</summary>
        Installed,
        /// <summary>This device was able to check in with the configuration manager service successfully.</summary>
        Healthy,
        /// <summary>The configuration manager agent failed to install.</summary>
        InstallFailed,
        /// <summary>The update from version x to version y of the configuration manager agent failed. </summary>
        UpdateFailed,
        /// <summary>The configuration manager agent was able to reach the configuration manager service in the past but is now no longer able to. </summary>
        CommunicationError,
    }
}
