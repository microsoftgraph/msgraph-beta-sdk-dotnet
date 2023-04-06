using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum GroupAccessType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "secret")]
        Secret,
        [EnumMember(Value = "public")]
        Public,
    }
}
