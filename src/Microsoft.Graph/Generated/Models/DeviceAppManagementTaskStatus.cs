namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DeviceAppManagementTaskStatus {
        /// <summary>State is undefined.</summary>
        Unknown,
        /// <summary>The task is ready for review.</summary>
        Pending,
        /// <summary>The task has been accepted and is being worked on.</summary>
        Active,
        /// <summary>The work is complete.</summary>
        Completed,
        /// <summary>The task was rejected.</summary>
        Rejected,
    }
}
