using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public enum AlertStatusType {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
