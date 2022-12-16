namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
