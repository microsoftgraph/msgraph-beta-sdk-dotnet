using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SearchContent {
        [EnumMember(Value = "sharedContent")]
        SharedContent,
        [EnumMember(Value = "privateContent")]
        PrivateContent,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
