using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EndUserNotificationPreference {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "custom")]
        Custom,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
