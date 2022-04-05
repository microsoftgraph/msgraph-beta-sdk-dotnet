namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public enum ManagementActionStatus {
        ToAddress,
        Completed,
        Error,
        TimeOut,
        InProgress,
        Planned,
        ResolvedBy3rdParty,
        ResolvedThroughAlternateMitigation,
        RiskAccepted,
        UnknownFutureValue,
    }
}
