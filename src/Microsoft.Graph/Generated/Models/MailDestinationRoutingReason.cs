namespace Microsoft.Graph.Beta.Models {
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
