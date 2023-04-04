using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamsAppInstallationScopes {
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "groupChat")]
        GroupChat,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
