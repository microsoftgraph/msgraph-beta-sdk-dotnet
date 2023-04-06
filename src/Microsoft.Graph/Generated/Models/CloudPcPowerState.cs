using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcPowerState {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "poweredOff")]
        PoweredOff,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
