using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkDeviceOperationType {
        [EnumMember(Value = "deviceRestart")]
        DeviceRestart,
        [EnumMember(Value = "configUpdate")]
        ConfigUpdate,
        [EnumMember(Value = "deviceDiagnostics")]
        DeviceDiagnostics,
        [EnumMember(Value = "softwareUpdate")]
        SoftwareUpdate,
        [EnumMember(Value = "deviceManagementAgentConfigUpdate")]
        DeviceManagementAgentConfigUpdate,
        [EnumMember(Value = "remoteLogin")]
        RemoteLogin,
        [EnumMember(Value = "remoteLogout")]
        RemoteLogout,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
