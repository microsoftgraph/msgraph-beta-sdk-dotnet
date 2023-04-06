using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TlpLevel {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "white")]
        White,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "amber")]
        Amber,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
