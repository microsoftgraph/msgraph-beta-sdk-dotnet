using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported setting types</summary>
    public enum DeviceManagementConfigurationSettingVisibility {
        /// <summary>Default. Not visible.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Visible to setting catalog policy type.</summary>
        [EnumMember(Value = "settingsCatalog")]
        SettingsCatalog,
        /// <summary>Visible to template policy type.</summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
