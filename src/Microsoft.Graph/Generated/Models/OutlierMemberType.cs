using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OutlierMemberType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
