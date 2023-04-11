using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SharingDomainRestrictionMode {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "allowList")]
        AllowList,
        [EnumMember(Value = "blockList")]
        BlockList,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
