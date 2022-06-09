namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum MacOSGatekeeperAppSources {
        /// <summary>Device default value, no intent.</summary>
        NotConfigured,
        /// <summary>Only apps from the Mac AppStore can be run.</summary>
        MacAppStore,
        /// <summary>Only apps from the Mac AppStore and identified developers can be run.</summary>
        MacAppStoreAndIdentifiedDevelopers,
        /// <summary>Apps from anywhere can be run.</summary>
        Anywhere,
    }
}
