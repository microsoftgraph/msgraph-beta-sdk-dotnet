namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceGuardVirtualizationBasedSecurityState {
        Running,
        RebootRequired,
        Require64BitArchitecture,
        NotLicensed,
        NotConfigured,
        DoesNotMeetHardwareRequirements,
        Other,
    }
}
