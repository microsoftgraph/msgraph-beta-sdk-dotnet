namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum CaseOperationStatus {
        NotStarted,
        SubmissionFailed,
        Running,
        Succeeded,
        PartiallySucceeded,
        Failed,
        UnknownFutureValue,
    }
}
