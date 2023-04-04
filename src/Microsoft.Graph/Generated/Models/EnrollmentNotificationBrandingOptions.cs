using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
    public enum EnrollmentNotificationBrandingOptions {
        /// <summary>Indicates that the template has no branding.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Indicates that the Company Logo is included in the notification.</summary>
        [EnumMember(Value = "includeCompanyLogo")]
        IncludeCompanyLogo,
        /// <summary>Indicates that the Company Name is included in the notification.</summary>
        [EnumMember(Value = "includeCompanyName")]
        IncludeCompanyName,
        /// <summary>Indicates that the Contact Information is included in the notification.</summary>
        [EnumMember(Value = "includeContactInformation")]
        IncludeContactInformation,
        /// <summary>Indicates that the Company Portal Link is included in the notification.</summary>
        [EnumMember(Value = "includeCompanyPortalLink")]
        IncludeCompanyPortalLink,
        /// <summary>Indicates that the DeviceDetails is included in the notification.</summary>
        [EnumMember(Value = "includeDeviceDetails")]
        IncludeDeviceDetails,
        /// <summary>unknownFutureValue for evolvable enums pattern.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
