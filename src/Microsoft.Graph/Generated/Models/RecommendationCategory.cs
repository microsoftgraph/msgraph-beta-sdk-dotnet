using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RecommendationCategory {
        [EnumMember(Value = "identityBestPractice")]
        IdentityBestPractice,
        [EnumMember(Value = "identitySecureScore")]
        IdentitySecureScore,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
