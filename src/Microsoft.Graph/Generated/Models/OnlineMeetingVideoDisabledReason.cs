using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnlineMeetingVideoDisabledReason {
        [EnumMember(Value = "watermarkProtection")]
        WatermarkProtection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
