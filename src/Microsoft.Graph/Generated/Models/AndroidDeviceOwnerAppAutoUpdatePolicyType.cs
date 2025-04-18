// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Android Device Owner possible values for states of the device&apos;s app auto update policy.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AndroidDeviceOwnerAppAutoUpdatePolicyType
    {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>The user can control auto-updates.</summary>
        [EnumMember(Value = "userChoice")]
        UserChoice,
        /// <summary>Apps are never auto-updated.</summary>
        [EnumMember(Value = "never")]
        Never,
        /// <summary>Apps are auto-updated over Wi-Fi only.</summary>
        [EnumMember(Value = "wiFiOnly")]
        WiFiOnly,
        /// <summary>Apps are auto-updated at any time. Data charges may apply.</summary>
        [EnumMember(Value = "always")]
        Always,
    }
}
