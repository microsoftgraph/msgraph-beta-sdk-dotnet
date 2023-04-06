using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum LongRunningOperationStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
