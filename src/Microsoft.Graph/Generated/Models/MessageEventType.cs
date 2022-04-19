namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of messageTrace entities.</summary>
    public enum MessageEventType {
        Received,
        Sent,
        Delivered,
        Failed,
        ProcessingFailed,
        DistributionGroupExpanded,
        Submitted,
        Delayed,
        Redirected,
        Resolved,
        Dropped,
        RecipientsAdded,
        MalwareDetected,
        MalwareDetectedInMessage,
        MalwareDetectedInAttachment,
        TtZapped,
        TtDelivered,
        SpamDetected,
        TransportRuleTriggered,
        DlpRuleTriggered,
        Journaled,
        UnknownFutureValue,
    }
}
