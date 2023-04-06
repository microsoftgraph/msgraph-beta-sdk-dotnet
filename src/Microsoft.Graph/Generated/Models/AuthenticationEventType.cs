using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationEventType {
        [EnumMember(Value = "tokenIssuanceStart")]
        TokenIssuanceStart,
        [EnumMember(Value = "pageRenderStart")]
        PageRenderStart,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
