using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AllowedAudiences {
        [EnumMember(Value = "me")]
        Me,
        [EnumMember(Value = "family")]
        Family,
        [EnumMember(Value = "contacts")]
        Contacts,
        [EnumMember(Value = "groupMembers")]
        GroupMembers,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "federatedOrganizations")]
        FederatedOrganizations,
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
