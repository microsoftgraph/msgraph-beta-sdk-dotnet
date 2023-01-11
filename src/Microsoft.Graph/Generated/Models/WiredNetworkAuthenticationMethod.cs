namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wired Network authentication method.</summary>
    public enum WiredNetworkAuthenticationMethod {
        /// <summary>Use an identity certificate for authentication.</summary>
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        DerivedCredential,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
    }
}
