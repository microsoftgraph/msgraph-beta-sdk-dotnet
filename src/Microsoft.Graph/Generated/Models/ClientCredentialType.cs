namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
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
