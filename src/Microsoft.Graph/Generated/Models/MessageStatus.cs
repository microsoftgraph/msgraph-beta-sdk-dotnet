namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum MessageStatus {
        GettingStatus,
        Pending,
        Failed,
        Delivered,
        Expanded,
        Quarantined,
        FilteredAsSpam,
        UnknownFutureValue,
    }
}
