using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcUserAccountType {
        [EnumMember(Value = "standardUser")]
        StandardUser,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
