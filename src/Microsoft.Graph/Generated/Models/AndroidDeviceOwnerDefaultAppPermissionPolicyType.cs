namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner default app permission policy type.</summary>
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
