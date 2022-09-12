namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum EasAuthenticationMethod {
        /// <summary>Authenticate with a username and password.</summary>
        UsernameAndPassword,
        /// <summary>Authenticate with a certificate.</summary>
        Certificate,
        /// <summary>Authenticate with derived credential.</summary>
        DerivedCredential,
    }
}
