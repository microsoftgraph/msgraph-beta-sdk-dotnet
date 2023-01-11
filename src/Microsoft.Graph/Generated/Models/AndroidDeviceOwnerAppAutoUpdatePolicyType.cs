namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner possible values for states of the device&apos;s app auto update policy.</summary>
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
