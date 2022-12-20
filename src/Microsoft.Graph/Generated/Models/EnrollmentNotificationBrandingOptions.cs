namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum EnrollmentNotificationBrandingOptions {
        /// <summary>Indicates that the template has no branding.</summary>
        None,
        /// <summary>Indicates that the Company Logo is included in the notification.</summary>
        IncludeCompanyLogo,
        /// <summary>Indicates that the Company Name is included in the notification.</summary>
        IncludeCompanyName,
        /// <summary>Indicates that the Contact Information is included in the notification.</summary>
        IncludeContactInformation,
        /// <summary>Indicates that the Company Portal Link is included in the notification.</summary>
        IncludeCompanyPortalLink,
        /// <summary>Indicates that the DeviceDetails is included in the notification.</summary>
        IncludeDeviceDetails,
        /// <summary>unknownFutureValue for evolvable enums pattern.</summary>
        UnknownFutureValue,
    }
}
