using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum MonitoringAction {
        [EnumMember(Value = "alertError")]
        AlertError,
        [EnumMember(Value = "pauseDeployment")]
        PauseDeployment,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
