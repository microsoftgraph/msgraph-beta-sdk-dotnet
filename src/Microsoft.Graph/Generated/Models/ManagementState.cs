namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ManagementState {
        Managed,
        RetirePending,
        RetireFailed,
        WipePending,
        WipeFailed,
        Unhealthy,
        DeletePending,
        RetireIssued,
        WipeIssued,
        WipeCanceled,
        RetireCanceled,
        Discovered,
    }
}
