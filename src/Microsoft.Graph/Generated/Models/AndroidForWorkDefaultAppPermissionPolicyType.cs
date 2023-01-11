namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android For Work default app permission policy type.</summary>
    public enum AndroidForWorkDefaultAppPermissionPolicyType {
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
