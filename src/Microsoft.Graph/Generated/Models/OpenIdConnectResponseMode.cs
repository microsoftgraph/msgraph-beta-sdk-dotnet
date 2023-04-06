using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OpenIdConnectResponseMode {
        [EnumMember(Value = "form_post")]
        Form_post,
        [EnumMember(Value = "query")]
        Query,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
