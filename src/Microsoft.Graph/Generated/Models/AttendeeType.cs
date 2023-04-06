using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AttendeeType {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "optional")]
        Optional,
        [EnumMember(Value = "resource")]
        Resource,
    }
}
