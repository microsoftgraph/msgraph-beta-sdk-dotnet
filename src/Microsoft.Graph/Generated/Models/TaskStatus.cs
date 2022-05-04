namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum TaskStatus {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
}
