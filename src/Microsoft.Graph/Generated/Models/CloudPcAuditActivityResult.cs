using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcAuditActivityResult {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "clientError")]
        ClientError,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "timeout")]
        Timeout,
        [EnumMember(Value = "other")]
        Other,
    }
}
