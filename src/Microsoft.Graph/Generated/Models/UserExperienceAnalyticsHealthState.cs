using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UserExperienceAnalyticsHealthState {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "insufficientData")]
        InsufficientData,
        [EnumMember(Value = "needsAttention")]
        NeedsAttention,
        [EnumMember(Value = "meetingGoals")]
        MeetingGoals,
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
