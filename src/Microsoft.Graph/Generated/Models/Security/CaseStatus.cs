namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum CaseStatus {
        Unknown,
        Active,
        PendingDelete,
        Closing,
        Closed,
        ClosedWithError,
        UnknownFutureValue,
    }
}
