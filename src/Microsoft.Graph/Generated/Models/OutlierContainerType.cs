using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OutlierContainerType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
