using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum HuntingRuleRunStatus {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "partiallyFailed")]
        PartiallyFailed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
