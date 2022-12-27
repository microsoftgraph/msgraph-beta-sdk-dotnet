namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum IncomingTokenType {
        None,
        PrimaryRefreshToken,
        Saml11,
        Saml20,
        UnknownFutureValue,
        RemoteDesktopToken,
    }
}
