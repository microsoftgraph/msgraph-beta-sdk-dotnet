using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcPartnerAgentInstallStatus {
        [EnumMember(Value = "installed")]
        Installed,
        [EnumMember(Value = "installFailed")]
        InstallFailed,
        [EnumMember(Value = "installing")]
        Installing,
        [EnumMember(Value = "uninstalling")]
        Uninstalling,
        [EnumMember(Value = "uninstallFailed")]
        UninstallFailed,
        [EnumMember(Value = "licensed")]
        Licensed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
