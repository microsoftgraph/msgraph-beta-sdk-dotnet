namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AppLogUploadState {
        /// <summary>Request is waiting to be processed or under processing</summary>
        Pending,
        /// <summary>Request is completed with file uploaded to Azure blob for download.</summary>
        Completed,
        /// <summary>Request finished processing and in error state.</summary>
        Failed,
    }
}
