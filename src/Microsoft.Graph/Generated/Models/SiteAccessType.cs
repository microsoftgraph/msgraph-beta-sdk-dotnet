using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SiteAccessType {
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "limited")]
        Limited,
    }
}
