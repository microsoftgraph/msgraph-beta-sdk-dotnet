using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OpenIdConnectResponseTypes {
        [EnumMember(Value = "code")]
        Code,
        [EnumMember(Value = "id_token")]
        Id_token,
        [EnumMember(Value = "token")]
        Token,
    }
}
