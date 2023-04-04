using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcDeviceImageOsStatus {
        [EnumMember(Value = "supported")]
        Supported,
        [EnumMember(Value = "supportedWithWarning")]
        SupportedWithWarning,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
