using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported setting types</summary>
    public enum DeviceManagementConfigurationSettingUsage {
        /// <summary>Default. No setting type specified.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Configuration setting type.</summary>
        [EnumMember(Value = "configuration")]
        Configuration,
        /// <summary>Compliance setting type.</summary>
        [EnumMember(Value = "compliance")]
        Compliance,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
