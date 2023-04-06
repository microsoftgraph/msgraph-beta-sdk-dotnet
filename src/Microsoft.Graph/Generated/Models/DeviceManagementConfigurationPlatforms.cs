using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported platform types.</summary>
    public enum DeviceManagementConfigurationPlatforms {
        /// <summary>None.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Android.</summary>
        [EnumMember(Value = "android")]
        Android,
        /// <summary>iOS.</summary>
        [EnumMember(Value = "iOS")]
        IOS,
        /// <summary>MacOS.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>Windows 10 X.</summary>
        [EnumMember(Value = "windows10X")]
        Windows10X,
        /// <summary>Windows 10.</summary>
        [EnumMember(Value = "windows10")]
        Windows10,
        /// <summary>Linux.</summary>
        [EnumMember(Value = "linux")]
        Linux,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
