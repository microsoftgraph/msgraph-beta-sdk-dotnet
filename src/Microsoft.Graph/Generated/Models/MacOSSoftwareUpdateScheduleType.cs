namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum MacOSSoftwareUpdateScheduleType {
        /// <summary>Always update.</summary>
        AlwaysUpdate,
        /// <summary>Update during time windows.</summary>
        UpdateDuringTimeWindows,
        /// <summary>Update outside of time windows.</summary>
        UpdateOutsideOfTimeWindows,
    }
}
