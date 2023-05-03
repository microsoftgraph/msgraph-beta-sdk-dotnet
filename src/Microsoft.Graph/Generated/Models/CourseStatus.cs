using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CourseStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
