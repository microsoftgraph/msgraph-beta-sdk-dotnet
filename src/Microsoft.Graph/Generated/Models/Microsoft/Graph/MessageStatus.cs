namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of messageRecipient entities.</summary>
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
