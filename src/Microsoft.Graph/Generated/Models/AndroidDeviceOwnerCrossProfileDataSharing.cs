namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AndroidDeviceOwnerCrossProfileDataSharing {
        /// <summary>Not configured; this value defaults to CROSS_PROFILE_DATA_SHARING_UNSPECIFIED.</summary>
        NotConfigured,
        /// <summary>Data cannot be shared from both the personal profile to work profile and the work profile to the personal profile.</summary>
        CrossProfileDataSharingBlocked,
        /// <summary>Prevents users from sharing data from the work profile to apps in the personal profile. Personal data can be shared with work apps.</summary>
        DataSharingFromWorkToPersonalBlocked,
        /// <summary>Data from either profile can be shared with the other profile.</summary>
        CrossProfileDataSharingAllowed,
        /// <summary>Unknown future value (reserved, not used right now)</summary>
        UnkownFutureValue,
    }
}
