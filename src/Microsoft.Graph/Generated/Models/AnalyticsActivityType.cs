using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AnalyticsActivityType {
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Meeting")]
        Meeting,
        [EnumMember(Value = "Focus")]
        Focus,
        [EnumMember(Value = "Chat")]
        Chat,
        [EnumMember(Value = "Call")]
        Call,
    }
}
