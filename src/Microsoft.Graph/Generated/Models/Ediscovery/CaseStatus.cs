namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum CaseStatus {
        Unknown,
        Active,
        PendingDelete,
        Closing,
        Closed,
        ClosedWithError,
    }
}
