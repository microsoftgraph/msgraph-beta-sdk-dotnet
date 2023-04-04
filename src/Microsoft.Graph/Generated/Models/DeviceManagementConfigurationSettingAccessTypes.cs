using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceManagementConfigurationSettingAccessTypes {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "copy")]
        Copy,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "get")]
        Get,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "execute")]
        Execute,
    }
}
