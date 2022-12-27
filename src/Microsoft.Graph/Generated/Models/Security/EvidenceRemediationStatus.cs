namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum EvidenceRemediationStatus {
        None,
        Remediated,
        Prevented,
        Blocked,
        NotFound,
        UnknownFutureValue,
    }
}
