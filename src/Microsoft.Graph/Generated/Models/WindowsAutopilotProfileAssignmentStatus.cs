namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsAutopilotProfileAssignmentStatus {
        Unknown,
        AssignedInSync,
        AssignedOutOfSync,
        AssignedUnkownSyncState,
        NotAssigned,
        Pending,
        Failed,
    }
}
