// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Subject Alternative Name Options.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum SubjectAlternativeNameType
    {
        /// <summary>No subject alternative name.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Email address.</summary>
        [EnumMember(Value = "emailAddress")]
        EmailAddress = 2,
        /// <summary>User Principal Name (UPN).</summary>
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName = 4,
        /// <summary>Custom Azure AD Attribute.</summary>
        [EnumMember(Value = "customAzureADAttribute")]
        CustomAzureADAttribute = 8,
        /// <summary>Domain Name Service (DNS).</summary>
        [EnumMember(Value = "domainNameService")]
        DomainNameService = 16,
        /// <summary>Universal Resource Identifier (URI).</summary>
        [EnumMember(Value = "universalResourceIdentifier")]
        UniversalResourceIdentifier = 32,
    }
}
