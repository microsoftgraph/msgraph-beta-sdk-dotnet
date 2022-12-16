namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ProtocolType {
        None,
        OAuth2,
        Ropc,
        WsFederation,
        Saml20,
        DeviceCode,
        UnknownFutureValue,
    }
}
