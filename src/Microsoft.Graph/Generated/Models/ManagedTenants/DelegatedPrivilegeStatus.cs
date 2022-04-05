namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public enum DelegatedPrivilegeStatus {
        None,
        DelegatedAdminPrivileges,
        UnknownFutureValue,
        GranularDelegatedAdminPrivileges,
        DelegatedAndGranularDelegetedAdminPrivileges,
    }
}
