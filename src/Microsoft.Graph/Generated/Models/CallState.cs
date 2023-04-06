using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CallState {
        [EnumMember(Value = "incoming")]
        Incoming,
        [EnumMember(Value = "establishing")]
        Establishing,
        [EnumMember(Value = "ringing")]
        Ringing,
        [EnumMember(Value = "established")]
        Established,
        [EnumMember(Value = "hold")]
        Hold,
        [EnumMember(Value = "transferring")]
        Transferring,
        [EnumMember(Value = "transferAccepted")]
        TransferAccepted,
        [EnumMember(Value = "redirecting")]
        Redirecting,
        [EnumMember(Value = "terminating")]
        Terminating,
        [EnumMember(Value = "terminated")]
        Terminated,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
