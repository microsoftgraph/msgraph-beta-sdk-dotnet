using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerUserRoleKind {
        [EnumMember(Value = "relationship")]
        Relationship,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
