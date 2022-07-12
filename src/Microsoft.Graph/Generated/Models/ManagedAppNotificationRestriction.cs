namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ManagedAppNotificationRestriction {
        /// <summary>Share all notifications.</summary>
        Allow,
        /// <summary>Do not share Orgnizational data in notifications.</summary>
        BlockOrganizationalData,
        /// <summary>Do not share notifications.</summary>
        Block,
    }
}
