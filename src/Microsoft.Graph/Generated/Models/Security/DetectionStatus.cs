using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DetectionStatus {
        [EnumMember(Value = "detected")]
        Detected,
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "prevented")]
        Prevented,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
