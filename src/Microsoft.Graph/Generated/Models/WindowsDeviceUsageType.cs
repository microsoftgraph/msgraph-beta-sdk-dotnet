using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsDeviceUsageType {
        /// <summary>Single User Device Type</summary>
        [EnumMember(Value = "singleUser")]
        SingleUser,
        /// <summary>Shared Device Type</summary>
        [EnumMember(Value = "shared")]
        Shared,
    }
}
