namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum BrowserSiteListStatus {
        /// <summary>A site list that has not yet been published</summary>
        Draft,
        /// <summary>A site list that has been published with no pending changes.</summary>
        Published,
        /// <summary>A site that has pending changes</summary>
        Pending,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shoudn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}
