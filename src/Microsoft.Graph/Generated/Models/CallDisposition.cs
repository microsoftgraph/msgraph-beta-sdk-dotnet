using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CallDisposition {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "simultaneousRing")]
        SimultaneousRing,
        [EnumMember(Value = "forward")]
        Forward,
    }
}
