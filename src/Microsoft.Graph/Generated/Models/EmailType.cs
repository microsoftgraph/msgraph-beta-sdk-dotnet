using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EmailType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "main")]
        Main,
        [EnumMember(Value = "other")]
        Other,
    }
}
