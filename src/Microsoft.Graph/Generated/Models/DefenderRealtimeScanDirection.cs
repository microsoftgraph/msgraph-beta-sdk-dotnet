namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DefenderRealtimeScanDirection {
        /// <summary>0 (default) – Monitor all files(bi-directional)</summary>
        MonitorAllFiles,
        /// <summary>Monitor incoming files only.</summary>
        MonitorIncomingFilesOnly,
        /// <summary>Monitor outgoing files only.</summary>
        MonitorOutgoingFilesOnly,
    }
}
