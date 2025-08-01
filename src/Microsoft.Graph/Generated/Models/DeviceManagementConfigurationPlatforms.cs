// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Supported platform types.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum DeviceManagementConfigurationPlatforms
    {
        /// <summary>Indicates the settings contained in this configuration don&apos;t have a platform set.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Indicates that the settings contained in associated configuration applies to the Android operating system. </summary>
        [EnumMember(Value = "android")]
        Android = 2,
        /// <summary>Indicates that the settings contained in associated configuration applies to the iOS operating system.</summary>
        [EnumMember(Value = "iOS")]
        IOS = 4,
        /// <summary>Indicates that the settings contained in associated configuration applies to the MacOS operating system.</summary>
        [EnumMember(Value = "macOS")]
        MacOS = 8,
        /// <summary>Indicates that the settings contained in associated configuration applies to the Windows 10X operating system.</summary>
        [EnumMember(Value = "windows10X")]
        Windows10X = 16,
        /// <summary>Indicates that the settings contained in associated configuration applies to the Windows 10 operating system.</summary>
        [EnumMember(Value = "windows10")]
        Windows10 = 32,
        /// <summary>Indicates that the settings contained in associated configuration applies to the Linux operating system.</summary>
        [EnumMember(Value = "linux")]
        Linux = 64,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 128,
        /// <summary>Indicates that the settings contained in associated configuration applies to the android operating system corporate owned devices.</summary>
        [EnumMember(Value = "androidEnterprise")]
        AndroidEnterprise = 256,
        /// <summary>Indicates that the settings contained in associated configuration applies to the android open source operating system.</summary>
        [EnumMember(Value = "aosp")]
        Aosp = 512,
        /// <summary>Indicates that the settings contained in associated configuration applies to visionOS platform.</summary>
        [EnumMember(Value = "visionOS")]
        VisionOS = 1024,
        /// <summary>Indicates that the settings contained in associated configuration applies to the tvOS platform.</summary>
        [EnumMember(Value = "tvOS")]
        TvOS = 2048,
    }
}
