using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum ActionAfterRetentionPeriod {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "startDispositionReview")]
        StartDispositionReview,
        [EnumMember(Value = "relabel")]
        Relabel,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
