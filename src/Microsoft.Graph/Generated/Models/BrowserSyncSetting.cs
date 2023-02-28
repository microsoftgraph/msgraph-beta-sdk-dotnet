namespace Microsoft.Graph.Beta.Models {
    /// <summary>Allow(Not Configured) or prevent(Block) the syncing of Microsoft Edge Browser settings. Option to prevent syncing across devices, but allow user override.</summary>
    public enum BrowserSyncSetting {
        /// <summary>Default – Allow syncing of browser settings across devices.</summary>
        NotConfigured,
        /// <summary>Prevent syncing of browser settings across user devices, allow user override of setting.</summary>
        BlockedWithUserOverride,
        /// <summary>Absolutely prevent syncing of browser settings across user devices.</summary>
        Blocked,
    }
}
