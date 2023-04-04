using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AllowedRolePrincipalTypes {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
