using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public enum PfsGroup {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "pfs1")]
        Pfs1,
        [EnumMember(Value = "pfs2")]
        Pfs2,
        [EnumMember(Value = "pfs14")]
        Pfs14,
        [EnumMember(Value = "pfs24")]
        Pfs24,
        [EnumMember(Value = "pfs2048")]
        Pfs2048,
        [EnumMember(Value = "pfsmm")]
        Pfsmm,
        [EnumMember(Value = "ecp256")]
        Ecp256,
        [EnumMember(Value = "ecp384")]
        Ecp384,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
