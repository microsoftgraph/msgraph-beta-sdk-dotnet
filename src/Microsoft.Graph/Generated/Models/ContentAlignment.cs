using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ContentAlignment {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "right")]
        Right,
        [EnumMember(Value = "center")]
        Center,
    }
}
