using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Subject Alternative Name Options.</summary>
    public enum SubjectAlternativeNameType {
        /// <summary>No subject alternative name.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Email address.</summary>
        [EnumMember(Value = "emailAddress")]
        EmailAddress,
        /// <summary>User Principal Name (UPN).</summary>
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName,
        /// <summary>Custom Azure AD Attribute.</summary>
        [EnumMember(Value = "customAzureADAttribute")]
        CustomAzureADAttribute,
        /// <summary>Domain Name Service (DNS).</summary>
        [EnumMember(Value = "domainNameService")]
        DomainNameService,
        /// <summary>Universal Resource Identifier (URI).</summary>
        [EnumMember(Value = "universalResourceIdentifier")]
        UniversalResourceIdentifier,
    }
}
