using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum IncomingTokenType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "primaryRefreshToken")]
        PrimaryRefreshToken,
        [EnumMember(Value = "saml11")]
        Saml11,
        [EnumMember(Value = "saml20")]
        Saml20,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "remoteDesktopToken")]
        RemoteDesktopToken,
    }
}
