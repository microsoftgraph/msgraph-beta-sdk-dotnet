using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AlertFeedback {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "truePositive")]
        TruePositive,
        [EnumMember(Value = "falsePositive")]
        FalsePositive,
        [EnumMember(Value = "benignPositive")]
        BenignPositive,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
