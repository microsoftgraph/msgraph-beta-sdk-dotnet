namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum LifecycleWorkflowProcessingStatus {
        Queued,
        InProgress,
        Completed,
        CompletedWithErrors,
        Canceled,
        Failed,
        UnknownFutureValue,
    }
}
