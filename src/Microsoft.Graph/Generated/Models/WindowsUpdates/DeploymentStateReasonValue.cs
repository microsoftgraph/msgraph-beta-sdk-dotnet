namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DeploymentStateReasonValue {
        ScheduledByOfferWindow,
        OfferingByRequest,
        PausedByRequest,
        PausedByMonitoring,
        UnknownFutureValue,
        FaultedByContentOutdated,
    }
}
