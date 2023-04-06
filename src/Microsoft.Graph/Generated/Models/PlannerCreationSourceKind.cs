using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerCreationSourceKind {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "external")]
        External,
        [EnumMember(Value = "publication")]
        Publication,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
