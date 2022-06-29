namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum ManagedAppDeviceThreatLevel {
        /// <summary>Value not configured</summary>
        NotConfigured,
        /// <summary>Device needs to have no threat</summary>
        Secured,
        /// <summary>Device needs to have a low threat.</summary>
        Low,
        /// <summary>Device needs to have not more than medium threat.</summary>
        Medium,
        /// <summary>Device needs to have not more than high threat</summary>
        High,
    }
}
