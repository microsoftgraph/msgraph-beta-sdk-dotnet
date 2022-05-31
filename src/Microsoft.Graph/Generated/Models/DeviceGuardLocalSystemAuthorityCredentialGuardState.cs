namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardState {
        /// <summary>Running</summary>
        Running,
        /// <summary>Reboot required</summary>
        RebootRequired,
        /// <summary>Not licensed for Credential Guard</summary>
        NotLicensed,
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Virtualization Based security is not running</summary>
        VirtualizationBasedSecurityNotRunning,
    }
}
