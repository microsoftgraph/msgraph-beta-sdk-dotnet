namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WiFiAuthenticationMethod {
        /// <summary>Use an identity certificate for authentication.</summary>
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        DerivedCredential,
    }
}
