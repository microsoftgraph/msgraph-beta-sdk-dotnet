namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the instantiate method.</summary>
    public enum SingleSignOnMode {
        None,
        OnPremisesKerberos,
        Saml,
        PingHeaderBased,
        AadHeaderBased,
        UnknownFutureValue,
    }
}
