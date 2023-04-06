using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DelegatedAdminAccessContainerType {
        [EnumMember(Value = "securityGroup")]
        SecurityGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
