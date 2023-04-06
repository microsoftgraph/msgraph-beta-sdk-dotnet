using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationStrengthRequirements {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "mfa")]
        Mfa,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
