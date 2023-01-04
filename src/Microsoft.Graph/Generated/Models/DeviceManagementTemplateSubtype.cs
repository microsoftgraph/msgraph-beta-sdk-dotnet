namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum DeviceManagementTemplateSubtype {
        /// <summary>Template has no subtype</summary>
        None,
        /// <summary>Endpoint security firewall subtype</summary>
        Firewall,
        /// <summary>Endpoint security disk encryption subtype</summary>
        DiskEncryption,
        /// <summary>Endpoint security attack surface reduction subtype</summary>
        AttackSurfaceReduction,
        /// <summary>Endpoint security endpoint detection and response subtype</summary>
        EndpointDetectionReponse,
        /// <summary>Endpoint security account protection subtype</summary>
        AccountProtection,
        /// <summary>Endpoint security anitivirus subtype</summary>
        Antivirus,
        /// <summary>Endpoint security firewall shared app subtype</summary>
        FirewallSharedAppList,
        /// <summary>Endpoint security firewall shared ip range list subtype</summary>
        FirewallSharedIpList,
        /// <summary>Endpoint security firewall shared port range list subtype</summary>
        FirewallSharedPortlist,
    }
}
