namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
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
