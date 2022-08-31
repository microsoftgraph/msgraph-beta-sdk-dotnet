namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum SingleSignOnMode {
        None,
        OnPremisesKerberos,
        Saml,
        PingHeaderBased,
        AadHeaderBased,
        UnknownFutureValue,
    }
}
