namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum WindowsAutopilotProfileAssignmentStatus {
        /// <summary>Unknown assignment status</summary>
        Unknown,
        /// <summary>Assigned successfully in Intune and in sync with Windows auto pilot program</summary>
        AssignedInSync,
        /// <summary>Assigned successfully in Intune and not in sync with Windows auto pilot program</summary>
        AssignedOutOfSync,
        /// <summary>Assigned successfully in Intune and either in-sync or out of sync with Windows auto pilot program</summary>
        AssignedUnkownSyncState,
        /// <summary>Not assigned</summary>
        NotAssigned,
        /// <summary>Pending assignment</summary>
        Pending,
        /// <summary> Assignment failed</summary>
        Failed,
    }
}
