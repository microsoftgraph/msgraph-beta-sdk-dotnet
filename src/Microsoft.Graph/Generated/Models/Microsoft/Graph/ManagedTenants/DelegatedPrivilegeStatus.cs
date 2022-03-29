namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public enum DelegatedPrivilegeStatus {
        None,
        DelegatedAdminPrivileges,
        UnknownFutureValue,
        GranularDelegatedAdminPrivileges,
        DelegatedAndGranularDelegetedAdminPrivileges,
    }
}
