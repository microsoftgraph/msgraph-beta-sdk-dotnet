using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConfirmedBy {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
