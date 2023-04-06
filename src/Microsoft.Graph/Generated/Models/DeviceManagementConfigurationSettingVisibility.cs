using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported setting types</summary>
    public enum DeviceManagementConfigurationSettingVisibility {
        /// <summary>Not visible</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Visible to setting catalog UX</summary>
        [EnumMember(Value = "settingsCatalog")]
        SettingsCatalog,
        /// <summary>Visible to template</summary>
        [EnumMember(Value = "template")]
        Template,
    }
}
