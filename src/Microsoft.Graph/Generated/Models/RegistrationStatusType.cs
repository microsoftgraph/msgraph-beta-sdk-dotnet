using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RegistrationStatusType {
        [EnumMember(Value = "registered")]
        Registered,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "capable")]
        Capable,
        [EnumMember(Value = "mfaRegistered")]
        MfaRegistered,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
