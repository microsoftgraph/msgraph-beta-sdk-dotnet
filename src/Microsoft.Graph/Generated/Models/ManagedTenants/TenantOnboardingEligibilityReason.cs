namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum TenantOnboardingEligibilityReason {
        None,
        ContractType,
        DelegatedAdminPrivileges,
        UsersCount,
        License,
        UnknownFutureValue,
    }
}
