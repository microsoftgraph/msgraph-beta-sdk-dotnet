using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcGalleryImageStatus {
        [EnumMember(Value = "supported")]
        Supported,
        [EnumMember(Value = "supportedWithWarning")]
        SupportedWithWarning,
        [EnumMember(Value = "notSupported")]
        NotSupported,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
