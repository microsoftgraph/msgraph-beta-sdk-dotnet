namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceManagementConfigurationTemplateFamily {
        None,
        EndpointSecurityAntivirus,
        EndpointSecurityDiskEncryption,
        EndpointSecurityFirewall,
        EndpointSecurityEndpointDetectionAndResponse,
        EndpointSecurityAttackSurfaceReduction,
        EndpointSecurityAccountProtection,
        EndpointSecurityApplicationControl,
        Baseline,
    }
}
