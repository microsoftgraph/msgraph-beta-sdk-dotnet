namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum PrintJobProcessingState {
        Unknown,
        Pending,
        Processing,
        Paused,
        Stopped,
        Completed,
        Canceled,
        Aborted,
    }
}
