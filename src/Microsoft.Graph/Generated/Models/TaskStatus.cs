namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum TaskStatus {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
}
