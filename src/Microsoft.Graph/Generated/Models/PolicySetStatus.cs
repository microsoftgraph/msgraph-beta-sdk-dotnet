namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum PolicySetStatus {
        /// <summary>Default Value.</summary>
        Unknown,
        /// <summary>All PolicySet items are now validating for corresponding settings of workloads.</summary>
        Validating,
        /// <summary>Post process complete for all PolicySet items but there are failures.</summary>
        PartialSuccess,
        /// <summary>All PolicySet items are deployed. Doesn’t mean that all deployment succeeded. </summary>
        Success,
        /// <summary>PolicySet processing completely failed.</summary>
        Error,
        /// <summary>PolicySet/PolicySetItem is not assigned to any group.</summary>
        NotAssigned,
    }
}
