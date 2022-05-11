namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DiscoverySource {
        /// <summary>DiscoverySource is Unknown.</summary>
        Unknown,
        /// <summary>Device is imported by admin.</summary>
        AdminImport,
        /// <summary>Device is added by Apple device enrollment program (Dep).</summary>
        DeviceEnrollmentProgram,
    }
}
