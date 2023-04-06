using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WeekIndex {
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value = "third")]
        Third,
        [EnumMember(Value = "fourth")]
        Fourth,
        [EnumMember(Value = "last")]
        Last,
    }
}
