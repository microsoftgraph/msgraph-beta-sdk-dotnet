namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidDeviceOwnerDefaultAppPermissionPolicyType {
        /// <summary>Device default value, no intent.</summary>
        DeviceDefault,
        /// <summary>Prompt.</summary>
        Prompt,
        /// <summary>Auto grant.</summary>
        AutoGrant,
        /// <summary>Auto deny.</summary>
        AutoDeny,
    }
}
