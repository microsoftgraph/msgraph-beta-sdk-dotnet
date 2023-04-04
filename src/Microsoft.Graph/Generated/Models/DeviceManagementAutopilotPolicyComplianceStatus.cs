using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceManagementAutopilotPolicyComplianceStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "compliant")]
        Compliant,
        [EnumMember(Value = "installed")]
        Installed,
        [EnumMember(Value = "notCompliant")]
        NotCompliant,
        [EnumMember(Value = "notInstalled")]
        NotInstalled,
        [EnumMember(Value = "error")]
        Error,
    }
}
