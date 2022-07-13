namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum UserMailboxSetting {
        None,
        JunkMailDeletion,
        IsFromAddressInAddressBook,
        IsFromAddressInAddressSafeList,
        IsFromAddressInAddressBlockList,
        IsFromAddressInAddressImplicitSafeList,
        IsFromAddressInAddressImplicitJunkList,
        IsFromDomainInDomainSafeList,
        IsFromDomainInDomainBlockList,
        IsRecipientInRecipientSafeList,
        CustomRule,
        JunkMailRule,
        SenderPraPresent,
        FromFirstTimeSender,
        Exclusive,
        PriorSeenPass,
        SenderAuthenticationSucceeded,
        IsJunkMailRuleEnabled,
        UnknownFutureValue,
    }
}
