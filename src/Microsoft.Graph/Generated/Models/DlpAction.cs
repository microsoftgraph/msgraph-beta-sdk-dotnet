using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DlpAction {
        [EnumMember(Value = "notifyUser")]
        NotifyUser,
        [EnumMember(Value = "blockAccess")]
        BlockAccess,
        [EnumMember(Value = "deviceRestriction")]
        DeviceRestriction,
    }
}
