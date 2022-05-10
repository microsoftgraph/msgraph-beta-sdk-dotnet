namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DriverApprovalStatus {
        /// <summary>This indicates a driver needs IT admin&apos;s review.</summary>
        NeedsReview,
        /// <summary>This indicates IT admin has declined a driver.</summary>
        Declined,
        /// <summary>This indicates IT admin has approved a driver.</summary>
        Approved,
        /// <summary>This indicates IT admin has suspended a driver.</summary>
        Suspended,
    }
}
