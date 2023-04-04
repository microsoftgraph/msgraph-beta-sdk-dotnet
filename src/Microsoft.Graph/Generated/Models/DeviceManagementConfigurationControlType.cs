using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting control type representation in the UX</summary>
    public enum DeviceManagementConfigurationControlType {
        /// <summary>Don’t override default</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>Display Choice in dropdown</summary>
        [EnumMember(Value = "dropdown")]
        Dropdown,
        /// <summary>Display text input in small text input</summary>
        [EnumMember(Value = "smallTextBox")]
        SmallTextBox,
        /// <summary>Display text input in large text input</summary>
        [EnumMember(Value = "largeTextBox")]
        LargeTextBox,
        /// <summary>Allow for toggle control type</summary>
        [EnumMember(Value = "toggle")]
        Toggle,
        /// <summary>Allow for multiheader grid control type</summary>
        [EnumMember(Value = "multiheaderGrid")]
        MultiheaderGrid,
        /// <summary>Allow for context pane control type</summary>
        [EnumMember(Value = "contextPane")]
        ContextPane,
    }
}
