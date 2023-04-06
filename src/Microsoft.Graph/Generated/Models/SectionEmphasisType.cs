using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SectionEmphasisType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "neutral")]
        Neutral,
        [EnumMember(Value = "soft")]
        Soft,
        [EnumMember(Value = "strong")]
        Strong,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
