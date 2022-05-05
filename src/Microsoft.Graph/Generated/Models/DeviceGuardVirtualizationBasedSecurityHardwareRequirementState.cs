namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceGuardVirtualizationBasedSecurityHardwareRequirementState {
        MeetHardwareRequirements,
        SecureBootRequired,
        DmaProtectionRequired,
        HyperVNotSupportedForGuestVM,
        HyperVNotAvailable,
    }
}
