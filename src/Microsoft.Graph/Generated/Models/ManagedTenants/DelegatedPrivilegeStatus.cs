namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum DelegatedPrivilegeStatus {
        None,
        DelegatedAdminPrivileges,
        UnknownFutureValue,
        GranularDelegatedAdminPrivileges,
        DelegatedAndGranularDelegetedAdminPrivileges,
    }
}
