using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum PurgeType {
        [EnumMember(Value = "recoverable")]
        Recoverable,
        [EnumMember(Value = "permanentlyDeleted")]
        PermanentlyDeleted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
