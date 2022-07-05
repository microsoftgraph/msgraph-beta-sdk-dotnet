namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public enum SingleSignOnMode {
        None,
        OnPremisesKerberos,
        Saml,
        PingHeaderBased,
        AadHeaderBased,
        UnknownFutureValue,
    }
}
