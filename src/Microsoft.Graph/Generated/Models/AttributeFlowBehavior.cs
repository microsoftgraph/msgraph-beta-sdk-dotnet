using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AttributeFlowBehavior {
        [EnumMember(Value = "FlowWhenChanged")]
        FlowWhenChanged,
        [EnumMember(Value = "FlowAlways")]
        FlowAlways,
    }
}
