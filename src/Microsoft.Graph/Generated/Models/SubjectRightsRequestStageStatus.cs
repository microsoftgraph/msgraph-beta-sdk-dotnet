using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SubjectRightsRequestStageStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "current")]
        Current,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
