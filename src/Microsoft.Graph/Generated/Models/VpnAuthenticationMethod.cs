namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum VpnAuthenticationMethod {
        /// <summary>Authenticate with a certificate.</summary>
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        UsernameAndPassword,
        /// <summary>Use Shared Secret for Authentication.  Only valid for iOS IKEv2.</summary>
        SharedSecret,
        /// <summary>Use Derived Credential for Authentication.</summary>
        DerivedCredential,
        /// <summary>Use Azure AD for authentication.</summary>
        AzureAD,
    }
}
