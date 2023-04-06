using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported setting types</summary>
    public enum DeviceManagementConfigurationSettingUsage {
        /// <summary>No setting type specified</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Configuration setting</summary>
        [EnumMember(Value = "configuration")]
        Configuration,
        /// <summary>Compliance setting</summary>
        [EnumMember(Value = "compliance")]
        Compliance,
    }
}
