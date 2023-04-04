using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Authoring source of a policy</summary>
    public enum SecurityBaselinePolicySourceType {
        [EnumMember(Value = "deviceConfiguration")]
        DeviceConfiguration,
        [EnumMember(Value = "deviceIntent")]
        DeviceIntent,
    }
}
