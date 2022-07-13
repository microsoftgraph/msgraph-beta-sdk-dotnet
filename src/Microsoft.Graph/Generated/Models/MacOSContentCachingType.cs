namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum MacOSContentCachingType {
        /// <summary>Default. Both user iCloud data and non-iCloud data will be cached.</summary>
        NotConfigured,
        /// <summary>Allow Apple&apos;s content caching service to cache user iCloud data.</summary>
        UserContentOnly,
        /// <summary>Allow Apple&apos;s content caching service to cache non-iCloud data (e.g. app and software updates).</summary>
        SharedContentOnly,
    }
}
