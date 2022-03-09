namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
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
