using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum WorkloadActionStatus {
        [EnumMember(Value = "toAddress")]
        ToAddress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "timeOut")]
        TimeOut,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
