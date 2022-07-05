namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ClientCredentialType {
        None,
        ClientSecret,
        ClientAssertion,
        FederatedIdentityCredential,
        ManagedIdentity,
        Certificate,
        UnknownFutureValue,
    }
}
