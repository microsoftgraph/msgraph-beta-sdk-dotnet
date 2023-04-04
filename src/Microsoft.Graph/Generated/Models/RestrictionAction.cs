using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RestrictionAction {
        [EnumMember(Value = "warn")]
        Warn,
        [EnumMember(Value = "audit")]
        Audit,
        [EnumMember(Value = "block")]
        Block,
    }
}
