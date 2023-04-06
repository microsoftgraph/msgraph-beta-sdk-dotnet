using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UserExperienceAnalyticsInsightSeverity {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "informational")]
        Informational,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "error")]
        Error,
    }
}
