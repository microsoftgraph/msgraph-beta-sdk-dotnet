namespace Microsoft.Graph.Beta.Models {
    /// <summary>The endpoint security policy type.</summary>
    public enum EndpointSecurityConfigurationType {
        /// <summary>Unknown.</summary>
        Unknown,
        /// <summary>Antivirus.</summary>
        Antivirus,
        /// <summary>Disk encryption.</summary>
        DiskEncryption,
        /// <summary>Firewall.</summary>
        Firewall,
        /// <summary>Endpoint detection and response.</summary>
        EndpointDetectionAndResponse,
        /// <summary>Attack surface reduction.</summary>
        AttackSurfaceReduction,
        /// <summary>Account protection.</summary>
        AccountProtection,
    }
}
