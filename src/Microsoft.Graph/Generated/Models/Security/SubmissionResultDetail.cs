using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionResultDetail {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "underInvestigation")]
        UnderInvestigation,
        [EnumMember(Value = "simulatedThreat")]
        SimulatedThreat,
        [EnumMember(Value = "allowedBySecOps")]
        AllowedBySecOps,
        [EnumMember(Value = "allowedByThirdPartyFilters")]
        AllowedByThirdPartyFilters,
        [EnumMember(Value = "messageNotFound")]
        MessageNotFound,
        [EnumMember(Value = "urlFileShouldNotBeBlocked")]
        UrlFileShouldNotBeBlocked,
        [EnumMember(Value = "urlFileShouldBeBlocked")]
        UrlFileShouldBeBlocked,
        [EnumMember(Value = "urlFileCannotMakeDecision")]
        UrlFileCannotMakeDecision,
        [EnumMember(Value = "domainImpersonation")]
        DomainImpersonation,
        [EnumMember(Value = "userImpersonation")]
        UserImpersonation,
        [EnumMember(Value = "brandImpersonation")]
        BrandImpersonation,
        [EnumMember(Value = "outboundShouldNotBeBlocked")]
        OutboundShouldNotBeBlocked,
        [EnumMember(Value = "outboundShouldBeBlocked")]
        OutboundShouldBeBlocked,
        [EnumMember(Value = "outboundBulk")]
        OutboundBulk,
        [EnumMember(Value = "outboundCannotMakeDecision")]
        OutboundCannotMakeDecision,
        [EnumMember(Value = "outboundNotRescanned")]
        OutboundNotRescanned,
        [EnumMember(Value = "zeroHourAutoPurgeAllowed")]
        ZeroHourAutoPurgeAllowed,
        [EnumMember(Value = "zeroHourAutoPurgeBlocked")]
        ZeroHourAutoPurgeBlocked,
        [EnumMember(Value = "zeroHourAutoPurgeQuarantineReleased")]
        ZeroHourAutoPurgeQuarantineReleased,
        [EnumMember(Value = "onPremisesSkip")]
        OnPremisesSkip,
        [EnumMember(Value = "allowedByTenantAllowBlockList")]
        AllowedByTenantAllowBlockList,
        [EnumMember(Value = "blockedByTenantAllowBlockList")]
        BlockedByTenantAllowBlockList,
        [EnumMember(Value = "allowedUrlByTenantAllowBlockList")]
        AllowedUrlByTenantAllowBlockList,
        [EnumMember(Value = "allowedFileByTenantAllowBlockList")]
        AllowedFileByTenantAllowBlockList,
        [EnumMember(Value = "allowedSenderByTenantAllowBlockList")]
        AllowedSenderByTenantAllowBlockList,
        [EnumMember(Value = "allowedRecipientByTenantAllowBlockList")]
        AllowedRecipientByTenantAllowBlockList,
        [EnumMember(Value = "blockedUrlByTenantAllowBlockList")]
        BlockedUrlByTenantAllowBlockList,
        [EnumMember(Value = "blockedFileByTenantAllowBlockList")]
        BlockedFileByTenantAllowBlockList,
        [EnumMember(Value = "blockedSenderByTenantAllowBlockList")]
        BlockedSenderByTenantAllowBlockList,
        [EnumMember(Value = "blockedRecipientByTenantAllowBlockList")]
        BlockedRecipientByTenantAllowBlockList,
        [EnumMember(Value = "allowedByConnection")]
        AllowedByConnection,
        [EnumMember(Value = "blockedByConnection")]
        BlockedByConnection,
        [EnumMember(Value = "allowedByExchangeTransportRule")]
        AllowedByExchangeTransportRule,
        [EnumMember(Value = "blockedByExchangeTransportRule")]
        BlockedByExchangeTransportRule,
        [EnumMember(Value = "quarantineReleased")]
        QuarantineReleased,
        [EnumMember(Value = "quarantineReleasedThenBlocked")]
        QuarantineReleasedThenBlocked,
        [EnumMember(Value = "junkMailRuleDisabled")]
        JunkMailRuleDisabled,
        [EnumMember(Value = "allowedByUserSetting")]
        AllowedByUserSetting,
        [EnumMember(Value = "blockedByUserSetting")]
        BlockedByUserSetting,
        [EnumMember(Value = "allowedByTenant")]
        AllowedByTenant,
        [EnumMember(Value = "blockedByTenant")]
        BlockedByTenant,
        [EnumMember(Value = "invalidFalsePositive")]
        InvalidFalsePositive,
        [EnumMember(Value = "invalidFalseNegative")]
        InvalidFalseNegative,
        [EnumMember(Value = "spoofBlocked")]
        SpoofBlocked,
        [EnumMember(Value = "goodReclassifiedAsBad")]
        GoodReclassifiedAsBad,
        [EnumMember(Value = "goodReclassifiedAsBulk")]
        GoodReclassifiedAsBulk,
        [EnumMember(Value = "goodReclassifiedAsGood")]
        GoodReclassifiedAsGood,
        [EnumMember(Value = "goodReclassifiedAsCannotMakeDecision")]
        GoodReclassifiedAsCannotMakeDecision,
        [EnumMember(Value = "badReclassifiedAsGood")]
        BadReclassifiedAsGood,
        [EnumMember(Value = "badReclassifiedAsBulk")]
        BadReclassifiedAsBulk,
        [EnumMember(Value = "badReclassifiedAsBad")]
        BadReclassifiedAsBad,
        [EnumMember(Value = "badReclassifiedAsCannotMakeDecision")]
        BadReclassifiedAsCannotMakeDecision,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
