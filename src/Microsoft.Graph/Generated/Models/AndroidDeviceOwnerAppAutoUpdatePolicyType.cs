namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidDeviceOwnerAppAutoUpdatePolicyType {
        /// <summary>Not configured; this value is ignored.</summary>
        NotConfigured,
        /// <summary>The user can control auto-updates.</summary>
        UserChoice,
        /// <summary>Apps are never auto-updated.</summary>
        Never,
        /// <summary>Apps are auto-updated over Wi-Fi only.</summary>
        WiFiOnly,
        /// <summary>Apps are auto-updated at any time. Data charges may apply.</summary>
        Always,
    }
}
