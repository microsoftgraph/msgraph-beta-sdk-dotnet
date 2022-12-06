namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum SubjectAlternativeNameType {
        /// <summary>No subject alternative name.</summary>
        None,
        /// <summary>Email address.</summary>
        EmailAddress,
        /// <summary>User Principal Name (UPN).</summary>
        UserPrincipalName,
        /// <summary>Custom Azure AD Attribute.</summary>
        CustomAzureADAttribute,
        /// <summary>Domain Name Service (DNS).</summary>
        DomainNameService,
        /// <summary>Universal Resource Identifier (URI).</summary>
        UniversalResourceIdentifier,
    }
}
