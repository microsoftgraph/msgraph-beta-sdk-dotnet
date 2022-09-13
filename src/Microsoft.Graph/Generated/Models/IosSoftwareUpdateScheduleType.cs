namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum IosSoftwareUpdateScheduleType {
        /// <summary>Update outside of active hours.</summary>
        UpdateOutsideOfActiveHours,
        /// <summary>Always update.</summary>
        AlwaysUpdate,
        /// <summary>Update during time windows.</summary>
        UpdateDuringTimeWindows,
        /// <summary>Update outside of time windows.</summary>
        UpdateOutsideOfTimeWindows,
    }
}
