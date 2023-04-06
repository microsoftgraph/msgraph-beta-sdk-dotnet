using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SignInFrequencyAuthenticationType {
        [EnumMember(Value = "primaryAndSecondaryAuthentication")]
        PrimaryAndSecondaryAuthentication,
        [EnumMember(Value = "secondaryAuthentication")]
        SecondaryAuthentication,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
