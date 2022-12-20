namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AndroidDeviceOwnerSystemUpdateInstallType {
        /// <summary>Device default behavior, which typically prompts the user to accept system updates.</summary>
        DeviceDefault,
        /// <summary>Postpone automatic install of updates up to 30 days.</summary>
        Postpone,
        /// <summary>Install automatically inside a daily maintenance window.</summary>
        Windowed,
        /// <summary>Automatically install updates as soon as possible.</summary>
        Automatic,
    }
}
