using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MediaDirection {
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "sendOnly")]
        SendOnly,
        [EnumMember(Value = "receiveOnly")]
        ReceiveOnly,
        [EnumMember(Value = "sendReceive")]
        SendReceive,
    }
}
