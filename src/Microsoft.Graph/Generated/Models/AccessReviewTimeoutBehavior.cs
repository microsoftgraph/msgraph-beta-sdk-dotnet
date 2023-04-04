using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccessReviewTimeoutBehavior {
        [EnumMember(Value = "keepAccess")]
        KeepAccess,
        [EnumMember(Value = "removeAccess")]
        RemoveAccess,
        [EnumMember(Value = "acceptAccessRecommendation")]
        AcceptAccessRecommendation,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
