namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi authentication method.</summary>
    public enum WiFiAuthenticationMethod {
        /// <summary>Use an identity certificate for authentication.</summary>
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        DerivedCredential,
    }
}
