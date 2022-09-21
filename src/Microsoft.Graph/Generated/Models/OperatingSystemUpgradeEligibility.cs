namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum OperatingSystemUpgradeEligibility {
        /// <summary>The device is upgraded to latest version of windows</summary>
        Upgraded,
        /// <summary>Not enough data available to compute the eligibility of device for windows upgrade</summary>
        Unknown,
        /// <summary>The device is not capable for windows upgrade</summary>
        NotCapable,
        /// <summary>The device is capable for windows upgrade</summary>
        Capable,
    }
}
