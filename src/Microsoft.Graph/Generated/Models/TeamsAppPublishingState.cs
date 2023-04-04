using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamsAppPublishingState {
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
