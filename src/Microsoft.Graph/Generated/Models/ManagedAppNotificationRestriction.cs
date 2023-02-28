namespace Microsoft.Graph.Beta.Models {
    /// <summary>Restrict managed app notification</summary>
    public enum ManagedAppNotificationRestriction {
        /// <summary>Share all notifications.</summary>
        Allow,
        /// <summary>Do not share Orgnizational data in notifications.</summary>
        BlockOrganizationalData,
        /// <summary>Do not share notifications.</summary>
        Block,
    }
}
