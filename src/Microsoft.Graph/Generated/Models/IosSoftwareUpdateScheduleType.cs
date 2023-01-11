namespace Microsoft.Graph.Beta.Models {
    /// <summary>Update schedule type for iOS software updates.</summary>
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
