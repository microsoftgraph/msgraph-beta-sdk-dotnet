namespace Microsoft.Graph.Beta.Models {
    public enum DeviceGuardVirtualizationBasedSecurityHardwareRequirementState {
        /// <summary>System meets hardware configuration requirements</summary>
        MeetHardwareRequirements,
        /// <summary>Secure boot required</summary>
        SecureBootRequired,
        /// <summary>DMA protection required</summary>
        DmaProtectionRequired,
        /// <summary>HyperV not supported for Guest VM</summary>
        HyperVNotSupportedForGuestVM,
        /// <summary>HyperV feature is not available</summary>
        HyperVNotAvailable,
    }
}
