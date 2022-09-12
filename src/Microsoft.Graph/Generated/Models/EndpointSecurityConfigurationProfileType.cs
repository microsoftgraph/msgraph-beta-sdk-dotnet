namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum EndpointSecurityConfigurationProfileType {
        /// <summary>Unknown.</summary>
        Unknown,
        /// <summary>Antivirus.</summary>
        Antivirus,
        /// <summary>Windows Security.</summary>
        WindowsSecurity,
        /// <summary>BitLocker.</summary>
        BitLocker,
        /// <summary>FileVault.</summary>
        FileVault,
        /// <summary>Firewall.</summary>
        Firewall,
        /// <summary>Firewall rules.</summary>
        FirewallRules,
        /// <summary>Endpoint detection and response.</summary>
        EndpointDetectionAndResponse,
        /// <summary>Device control.</summary>
        DeviceControl,
        /// <summary>App and browser isolation.</summary>
        AppAndBrowserIsolation,
        /// <summary>Exploit protection.</summary>
        ExploitProtection,
        /// <summary>Web protection.</summary>
        WebProtection,
        /// <summary>Application control.</summary>
        ApplicationControl,
        /// <summary>Attack surface reduction rules.</summary>
        AttackSurfaceReductionRules,
        /// <summary>Account protection.</summary>
        AccountProtection,
    }
}
