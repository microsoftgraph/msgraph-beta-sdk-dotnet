using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum MonitoringSignal {
        [EnumMember(Value = "rollback")]
        Rollback,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
