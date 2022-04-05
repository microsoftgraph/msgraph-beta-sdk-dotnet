namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public enum TenantOnboardingEligibilityReason {
        None,
        ContractType,
        DelegatedAdminPrivileges,
        UsersCount,
        License,
        UnknownFutureValue,
    }
}
