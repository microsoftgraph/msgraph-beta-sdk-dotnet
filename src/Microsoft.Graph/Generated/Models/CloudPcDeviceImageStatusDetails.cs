using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcDeviceImageStatusDetails {
        [EnumMember(Value = "internalServerError")]
        InternalServerError,
        [EnumMember(Value = "sourceImageNotFound")]
        SourceImageNotFound,
        [EnumMember(Value = "osVersionNotSupported")]
        OsVersionNotSupported,
        [EnumMember(Value = "sourceImageInvalid")]
        SourceImageInvalid,
        [EnumMember(Value = "sourceImageNotGeneralized")]
        SourceImageNotGeneralized,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
