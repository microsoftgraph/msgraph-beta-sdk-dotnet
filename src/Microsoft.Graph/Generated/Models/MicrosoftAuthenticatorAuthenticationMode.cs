using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MicrosoftAuthenticatorAuthenticationMode {
        [EnumMember(Value = "deviceBasedPush")]
        DeviceBasedPush,
        [EnumMember(Value = "push")]
        Push,
        [EnumMember(Value = "any")]
        Any,
    }
}
