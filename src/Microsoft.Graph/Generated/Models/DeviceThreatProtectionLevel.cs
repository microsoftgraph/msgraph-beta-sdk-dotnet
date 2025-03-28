// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Device threat protection levels for the Device Threat Protection API.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceThreatProtectionLevel
    {
        /// <summary>Default Value. Do not use.</summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
        /// <summary>Device Threat Level requirement: Secured. This is the most secure level, and represents that no threats were found on the device.</summary>
        [EnumMember(Value = "secured")]
        Secured,
        /// <summary>Device Threat Protection level requirement: Low. Low represents a severity of threat that poses minimal risk to the device or device data.</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>Device Threat Protection level requirement: Medium. Medium represents a severity of threat that poses moderate risk to the device or device data.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Device Threat Protection level requirement: High. High represents a severity of threat that poses severe risk to the device or device data.</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>Device Threat Protection level requirement: Not Set. Not set represents that there is no requirement for the device to meet a Threat Protection level.</summary>
        [EnumMember(Value = "notSet")]
        NotSet,
    }
}
