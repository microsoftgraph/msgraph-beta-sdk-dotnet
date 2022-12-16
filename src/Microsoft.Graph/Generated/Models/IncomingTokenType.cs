namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum IncomingTokenType {
        None,
        PrimaryRefreshToken,
        Saml11,
        Saml20,
        UnknownFutureValue,
        RemoteDesktopToken,
    }
}
