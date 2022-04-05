namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of domain entities.</summary>
    public enum FederatedIdpMfaBehavior {
        AcceptIfMfaDoneByFederatedIdp,
        EnforceMfaByFederatedIdp,
        RejectMfaByFederatedIdp,
        UnknownFutureValue,
    }
}
