using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported platform types.</summary>
    public enum DeviceManagementConfigurationPlatforms {
        /// <summary>Default. No platform type specified.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Settings for Android platform.</summary>
        [EnumMember(Value = "android")]
        Android,
        /// <summary>Settings for iOS platform.</summary>
        [EnumMember(Value = "iOS")]
        IOS,
        /// <summary>Settings for MacOS platform.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>Windows 10 X.</summary>
        [EnumMember(Value = "windows10X")]
        Windows10X,
        /// <summary>Settings for Windows 10 platform.</summary>
        [EnumMember(Value = "windows10")]
        Windows10,
        /// <summary>Settings for Linux platform.</summary>
        [EnumMember(Value = "linux")]
        Linux,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
