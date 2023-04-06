using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DeviceGuardVirtualizationBasedSecurityHardwareRequirementState {
        /// <summary>System meets hardware configuration requirements</summary>
        [EnumMember(Value = "meetHardwareRequirements")]
        MeetHardwareRequirements,
        /// <summary>Secure boot required</summary>
        [EnumMember(Value = "secureBootRequired")]
        SecureBootRequired,
        /// <summary>DMA protection required</summary>
        [EnumMember(Value = "dmaProtectionRequired")]
        DmaProtectionRequired,
        /// <summary>HyperV not supported for Guest VM</summary>
        [EnumMember(Value = "hyperVNotSupportedForGuestVM")]
        HyperVNotSupportedForGuestVM,
        /// <summary>HyperV feature is not available</summary>
        [EnumMember(Value = "hyperVNotAvailable")]
        HyperVNotAvailable,
    }
}
