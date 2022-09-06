namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum MailDestinationRoutingReason {
        None,
        MailFlowRule,
        SafeSender,
        BlockedSender,
        AdvancedSpamFiltering,
        DomainAllowList,
        DomainBlockList,
        NotInAddressBook,
        FirstTimeSender,
        AutoPurgeToInbox,
        AutoPurgeToJunk,
        AutoPurgeToDeleted,
        Outbound,
        NotJunk,
        Junk,
        UnknownFutureValue,
    }
}
