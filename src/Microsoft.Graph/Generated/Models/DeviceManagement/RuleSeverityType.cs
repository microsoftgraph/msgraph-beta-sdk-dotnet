using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public enum RuleSeverityType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "informational")]
        Informational,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
