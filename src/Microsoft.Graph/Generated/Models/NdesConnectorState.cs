namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum NdesConnectorState {
        /// <summary>State not available yet for this connector.</summary>
        None,
        /// <summary>Ndes connector has connected recently</summary>
        Active,
        /// <summary>No recent activity for the Ndes connector</summary>
        Inactive,
    }
}
