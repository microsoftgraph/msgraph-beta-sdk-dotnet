namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the directory singleton.</summary>
    public enum FederatedIdpMfaBehavior {
        AcceptIfMfaDoneByFederatedIdp,
        EnforceMfaByFederatedIdp,
        RejectMfaByFederatedIdp,
        UnknownFutureValue,
    }
}
