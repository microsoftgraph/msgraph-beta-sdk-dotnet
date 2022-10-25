namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum DeploymentStateReasonValue {
        ScheduledByOfferWindow,
        OfferingByRequest,
        PausedByRequest,
        PausedByMonitoring,
        UnknownFutureValue,
        FaultedByContentOutdated,
    }
}
