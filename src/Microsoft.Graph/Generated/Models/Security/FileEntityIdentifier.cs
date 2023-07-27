using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum FileEntityIdentifier {
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "initiatingProcessSHA1")]
        InitiatingProcessSHA1,
        [EnumMember(Value = "sha256")]
        Sha256,
        [EnumMember(Value = "initiatingProcessSHA256")]
        InitiatingProcessSHA256,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
