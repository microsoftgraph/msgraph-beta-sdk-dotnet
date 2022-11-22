namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum BrowserSharedCookieStatus {
        /// <summary>A sharedcookie that has been published</summary>
        Published,
        /// <summary>A sharedcookie that has been added pending publish</summary>
        PendingAdd,
        /// <summary>A sharedcookie that has been edited pending publish</summary>
        PendingEdit,
        /// <summary>A sharedcookie that has been deleted pending publish</summary>
        PendingDelete,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}
