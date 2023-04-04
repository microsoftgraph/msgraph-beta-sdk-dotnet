using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ProtocolType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "oAuth2")]
        OAuth2,
        [EnumMember(Value = "ropc")]
        Ropc,
        [EnumMember(Value = "wsFederation")]
        WsFederation,
        [EnumMember(Value = "saml20")]
        Saml20,
        [EnumMember(Value = "deviceCode")]
        DeviceCode,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
