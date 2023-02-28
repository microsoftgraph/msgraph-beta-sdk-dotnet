namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes the TemplateFamily for the Template entity</summary>
    public enum DeviceEnrollmentConfigurationType {
        /// <summary>Default. Set to unknown if the configuration type cannot be determined.</summary>
        Unknown,
        /// <summary>Indicates that configuration is of type limit which refers to number of devices a user is allowed to enroll.</summary>
        Limit,
        /// <summary>Indicates that configuration is of type platform restriction which refers to types of devices a user is allowed to enroll.</summary>
        PlatformRestrictions,
        /// <summary>Indicates that configuration is of type Windows Hello which refers to authentication method devices would use.</summary>
        WindowsHelloForBusiness,
        /// <summary>Indicates that configuration is of type default limit which refers to types of devices a user is allowed to enroll by default.</summary>
        DefaultLimit,
        /// <summary>Indicates that configuration is of type default platform restriction which refers to types of devices a user is allowed to enroll by default.</summary>
        DefaultPlatformRestrictions,
        /// <summary>Indicates that configuration is of type default Windows Hello which refers to authentication method devices would use by default.</summary>
        DefaultWindowsHelloForBusiness,
        /// <summary>Indicates that configuration is of type default Enrollment status page which refers to startup page displayed during OOBE in Autopilot devices by default.</summary>
        DefaultWindows10EnrollmentCompletionPageConfiguration,
        /// <summary>Indicates that configuration is of type Enrollment status page which refers to startup page displayed during OOBE in Autopilot devices.</summary>
        Windows10EnrollmentCompletionPageConfiguration,
        /// <summary>Indicates that configuration is of type Comanagement Authority which refers to policies applied to Co-Managed devices.</summary>
        DeviceComanagementAuthorityConfiguration,
        /// <summary>Indicates that configuration is of type single platform restriction which refers to types of devices a user is allowed to enroll.</summary>
        SinglePlatformRestriction,
        /// <summary>Unknown future value</summary>
        UnknownFutureValue,
        /// <summary>Indicates that configuration is of type Enrollment Notification which refers to types of notification a user receives during enrollment.</summary>
        EnrollmentNotificationsConfiguration,
    }
}
