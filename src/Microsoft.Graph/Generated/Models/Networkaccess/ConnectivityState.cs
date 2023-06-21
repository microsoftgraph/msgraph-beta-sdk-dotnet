using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public enum ConnectivityState {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "connected")]
        Connected,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
