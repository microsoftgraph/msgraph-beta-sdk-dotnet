namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum BrowserSyncSetting {
        /// <summary>Default – Allow syncing of browser settings across devices.</summary>
        NotConfigured,
        /// <summary>Prevent syncing of browser settings across user devices, allow user override of setting.</summary>
        BlockedWithUserOverride,
        /// <summary>Absolutely prevent syncing of browser settings across user devices.</summary>
        Blocked,
    }
}
