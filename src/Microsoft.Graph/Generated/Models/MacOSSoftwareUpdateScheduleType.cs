namespace Microsoft.Graph.Beta.Models {
    /// <summary>Update schedule type for macOS software updates.</summary>
    public enum MacOSSoftwareUpdateScheduleType {
        /// <summary>Always update.</summary>
        AlwaysUpdate,
        /// <summary>Update during time windows.</summary>
        UpdateDuringTimeWindows,
        /// <summary>Update outside of time windows.</summary>
        UpdateOutsideOfTimeWindows,
    }
}
