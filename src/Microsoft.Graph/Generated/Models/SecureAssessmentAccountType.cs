namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum SecureAssessmentAccountType {
        /// <summary>Indicates an Azure AD account in format of AzureAD\username@tenant.com.</summary>
        AzureADAccount,
        /// <summary>Indicates a domain account in format of domain\user or user@domain.com.</summary>
        DomainAccount,
        /// <summary>Indicates a local account in format of username.</summary>
        LocalAccount,
        /// <summary>Indicates a local guest account in format of test name.</summary>
        LocalGuestAccount,
    }
}
