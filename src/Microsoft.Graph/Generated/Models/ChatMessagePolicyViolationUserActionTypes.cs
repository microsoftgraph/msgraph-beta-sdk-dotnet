using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ChatMessagePolicyViolationUserActionTypes {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "override")]
        Override,
        [EnumMember(Value = "reportFalsePositive")]
        ReportFalsePositive,
    }
}
