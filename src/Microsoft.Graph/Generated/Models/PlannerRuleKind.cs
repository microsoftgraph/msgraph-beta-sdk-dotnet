using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerRuleKind {
        [EnumMember(Value = "taskRule")]
        TaskRule,
        [EnumMember(Value = "bucketRule")]
        BucketRule,
        [EnumMember(Value = "planRule")]
        PlanRule,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
