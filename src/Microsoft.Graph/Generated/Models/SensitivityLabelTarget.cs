using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SensitivityLabelTarget {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "unifiedGroup")]
        UnifiedGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "teamwork")]
        Teamwork,
    }
}
