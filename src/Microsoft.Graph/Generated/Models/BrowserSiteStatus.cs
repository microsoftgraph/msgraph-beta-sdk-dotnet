namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum BrowserSiteStatus {
        /// <summary>A site that has been published</summary>
        Published,
        /// <summary>A site that has been added pending publish</summary>
        PendingAdd,
        /// <summary>A site that has been edited pending publish</summary>
        PendingEdit,
        /// <summary>A site that has been deleted pending publish</summary>
        PendingDelete,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}
