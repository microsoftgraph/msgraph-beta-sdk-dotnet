using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ReplyRestriction {
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "authorAndModerators")]
        AuthorAndModerators,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
