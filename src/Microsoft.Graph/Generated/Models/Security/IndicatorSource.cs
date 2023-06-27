using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum IndicatorSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "osint")]
        Osint,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
