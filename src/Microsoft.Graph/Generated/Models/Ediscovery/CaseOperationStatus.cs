namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum CaseOperationStatus {
        NotStarted,
        SubmissionFailed,
        Running,
        Succeeded,
        PartiallySucceeded,
        Failed,
    }
}
