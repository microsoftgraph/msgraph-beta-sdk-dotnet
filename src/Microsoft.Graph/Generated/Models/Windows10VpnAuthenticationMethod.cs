namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum Windows10VpnAuthenticationMethod {
        /// <summary>Authenticate with a certificate.</summary>
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        UsernameAndPassword,
        /// <summary>Authentication method is specified in custom EAP XML.</summary>
        CustomEapXml,
        /// <summary>Use Derived Credential for authentication.</summary>
        DerivedCredential,
    }
}
