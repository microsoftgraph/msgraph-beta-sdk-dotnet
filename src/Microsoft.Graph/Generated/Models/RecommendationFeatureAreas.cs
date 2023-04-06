using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RecommendationFeatureAreas {
        [EnumMember(Value = "users")]
        Users,
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "devices")]
        Devices,
        [EnumMember(Value = "applications")]
        Applications,
        [EnumMember(Value = "accessReviews")]
        AccessReviews,
        [EnumMember(Value = "conditionalAccess")]
        ConditionalAccess,
        [EnumMember(Value = "governance")]
        Governance,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
