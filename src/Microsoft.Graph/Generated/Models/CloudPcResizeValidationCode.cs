using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcResizeValidationCode {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "cloudPcNotFound")]
        CloudPcNotFound,
        [EnumMember(Value = "operationConflict")]
        OperationConflict,
        [EnumMember(Value = "operationNotSupported")]
        OperationNotSupported,
        [EnumMember(Value = "targetLicenseHasAssigned")]
        TargetLicenseHasAssigned,
        [EnumMember(Value = "internalServerError")]
        InternalServerError,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
