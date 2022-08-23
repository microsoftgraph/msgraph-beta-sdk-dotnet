namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum EdgeTelemetryMode {
        /// <summary>Default – No telemetry data collected or sent</summary>
        NotConfigured,
        /// <summary>Allow sending intranet history only: Only send browsing history data for intranet sites</summary>
        Intranet,
        /// <summary>Allow sending internet history only: Only send browsing history data for internet sites</summary>
        Internet,
        /// <summary>Allow sending both intranet and internet history: Send browsing history data for intranet and internet sites</summary>
        IntranetAndInternet,
    }
}
