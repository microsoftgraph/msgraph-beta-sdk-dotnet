namespace Microsoft.Graph.Beta.Models {
    public enum DeviceGuardVirtualizationBasedSecurityState {
        /// <summary>Running</summary>
        Running,
        /// <summary>Root required</summary>
        RebootRequired,
        /// <summary>64 bit architecture required</summary>
        Require64BitArchitecture,
        /// <summary>Not licensed</summary>
        NotLicensed,
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>System does not meet hardware requirements</summary>
        DoesNotMeetHardwareRequirements,
        /// <summary>Other. Event logs in microsoft-Windows-DeviceGuard have more details.</summary>
        Other,
    }
}
