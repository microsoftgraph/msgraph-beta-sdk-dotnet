using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum UserMailboxSetting {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "junkMailDeletion")]
        JunkMailDeletion,
        [EnumMember(Value = "isFromAddressInAddressBook")]
        IsFromAddressInAddressBook,
        [EnumMember(Value = "isFromAddressInAddressSafeList")]
        IsFromAddressInAddressSafeList,
        [EnumMember(Value = "isFromAddressInAddressBlockList")]
        IsFromAddressInAddressBlockList,
        [EnumMember(Value = "isFromAddressInAddressImplicitSafeList")]
        IsFromAddressInAddressImplicitSafeList,
        [EnumMember(Value = "isFromAddressInAddressImplicitJunkList")]
        IsFromAddressInAddressImplicitJunkList,
        [EnumMember(Value = "isFromDomainInDomainSafeList")]
        IsFromDomainInDomainSafeList,
        [EnumMember(Value = "isFromDomainInDomainBlockList")]
        IsFromDomainInDomainBlockList,
        [EnumMember(Value = "isRecipientInRecipientSafeList")]
        IsRecipientInRecipientSafeList,
        [EnumMember(Value = "customRule")]
        CustomRule,
        [EnumMember(Value = "junkMailRule")]
        JunkMailRule,
        [EnumMember(Value = "senderPraPresent")]
        SenderPraPresent,
        [EnumMember(Value = "fromFirstTimeSender")]
        FromFirstTimeSender,
        [EnumMember(Value = "exclusive")]
        Exclusive,
        [EnumMember(Value = "priorSeenPass")]
        PriorSeenPass,
        [EnumMember(Value = "senderAuthenticationSucceeded")]
        SenderAuthenticationSucceeded,
        [EnumMember(Value = "isJunkMailRuleEnabled")]
        IsJunkMailRuleEnabled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
