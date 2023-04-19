using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public enum ImportanceScore {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "veryHigh")]
        VeryHigh,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
