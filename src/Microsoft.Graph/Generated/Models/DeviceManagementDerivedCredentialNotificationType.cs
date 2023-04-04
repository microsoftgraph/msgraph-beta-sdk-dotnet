using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported values for the notification type to use.</summary>
    public enum DeviceManagementDerivedCredentialNotificationType {
        /// <summary>None</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Company Portal</summary>
        [EnumMember(Value = "companyPortal")]
        CompanyPortal,
        /// <summary>Email</summary>
        [EnumMember(Value = "email")]
        Email,
    }
}
