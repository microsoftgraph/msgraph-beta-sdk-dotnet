using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkSoftwareFreshness {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "latest")]
        Latest,
        [EnumMember(Value = "updateAvailable")]
        UpdateAvailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
