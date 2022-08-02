namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DelegatedPrivilegeStatus {
        None,
        DelegatedAdminPrivileges,
        UnknownFutureValue,
        GranularDelegatedAdminPrivileges,
        DelegatedAndGranularDelegetedAdminPrivileges,
    }
}
