namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum TaskStatus {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
}
