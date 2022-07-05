namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AdminConsentState {
        /// <summary>Admin did not configure the item</summary>
        NotConfigured,
        /// <summary>Admin granted item</summary>
        Granted,
        /// <summary>Admin deos not grant item</summary>
        NotGranted,
    }
}
