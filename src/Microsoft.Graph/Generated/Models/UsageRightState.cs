using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UsageRightState {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "suspended")]
        Suspended,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
