namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum DeviceManagementConfigurationTemplateFamily {
        /// <summary>Default for Template Family when Policy is not linked to a Template</summary>
        None,
        /// <summary>Template Family for EndpointSecurityAntivirus that manages the discrete group of antivirus settings for managed devices</summary>
        EndpointSecurityAntivirus,
        /// <summary>Template Family for EndpointSecurityDiskEncryption that provides settings that are relevant for a devices built-in encryption  method, like FileVault or BitLocker</summary>
        EndpointSecurityDiskEncryption,
        /// <summary>Template Family for EndpointSecurityFirewall that helps configure a devices built-in firewall for device that run macOS and Windows 10</summary>
        EndpointSecurityFirewall,
        /// <summary>Template Family for EndpointSecurityEndpointDetectionAndResponse that facilitates management of the EDR settings and onboard devices to Microsoft Defender for Endpoint</summary>
        EndpointSecurityEndpointDetectionAndResponse,
        /// <summary>Template Family for EndpointSecurityAttackSurfaceReduction that help reduce your attack surfaces, by minimizing the places where your organization is vulnerable to cyberthreats and attacks</summary>
        EndpointSecurityAttackSurfaceReduction,
        /// <summary>Template Family for EndpointSecurityAccountProtection that facilitates protecting the identity and accounts of users</summary>
        EndpointSecurityAccountProtection,
        /// <summary>Template Family for ApplicationControl that helps mitigate security threats by restricting the applications that users can run and the code that runs in the System Core (kernel)</summary>
        EndpointSecurityApplicationControl,
        /// <summary>Template Family for EPM Elevation Rules</summary>
        EndpointSecurityEndpointPrivilegeManagement,
        /// <summary>Template Family for EnrollmentConfiguration</summary>
        EnrollmentConfiguration,
        /// <summary>Template Family for QuietTimeIndicates Template Family for all the Apps QuietTime policies and templates</summary>
        AppQuietTime,
        /// <summary>Template Family for Baseline</summary>
        Baseline,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
