namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidDeviceOwnerPlayStoreMode {
        /// <summary>Not Configured</summary>
        NotConfigured,
        /// <summary>Only apps that are in the policy are available and any app not in the policy will be automatically uninstalled from the device.</summary>
        AllowList,
        /// <summary>All apps are available and any app that should not be on the device should be explicitly marked as &apos;BLOCKED&apos; in the applications policy.</summary>
        BlockList,
    }
}
