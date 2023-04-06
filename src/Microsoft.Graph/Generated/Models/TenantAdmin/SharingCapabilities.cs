using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    public enum SharingCapabilities {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "externalUserSharingOnly")]
        ExternalUserSharingOnly,
        [EnumMember(Value = "externalUserAndGuestSharing")]
        ExternalUserAndGuestSharing,
        [EnumMember(Value = "existingExternalUserSharingOnly")]
        ExistingExternalUserSharingOnly,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
