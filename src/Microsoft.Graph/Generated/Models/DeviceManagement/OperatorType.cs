using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public enum OperatorType {
        [EnumMember(Value = "greaterOrEqual")]
        GreaterOrEqual,
        [EnumMember(Value = "equal")]
        Equal,
        [EnumMember(Value = "greater")]
        Greater,
        [EnumMember(Value = "less")]
        Less,
        [EnumMember(Value = "lessOrEqual")]
        LessOrEqual,
        [EnumMember(Value = "notEqual")]
        NotEqual,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
