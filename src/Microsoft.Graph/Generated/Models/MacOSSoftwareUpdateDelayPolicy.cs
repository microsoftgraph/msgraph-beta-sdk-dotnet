namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum MacOSSoftwareUpdateDelayPolicy {
        /// <summary>Software update delays will not be enforced.</summary>
        None,
        /// <summary>Force delays for OS software updates.</summary>
        DelayOSUpdateVisibility,
        /// <summary>Force delays for app software updates.</summary>
        DelayAppUpdateVisibility,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
        /// <summary>Force delays for major OS software updates.</summary>
        DelayMajorOsUpdateVisibility,
    }
}
