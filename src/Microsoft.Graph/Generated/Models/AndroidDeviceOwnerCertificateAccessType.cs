namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AndroidDeviceOwnerCertificateAccessType {
        /// <summary>Require user approval for all apps</summary>
        UserApproval,
        /// <summary>Pre-grant certificate access for specific apps (require user approval for other apps).</summary>
        SpecificApps,
        /// <summary>Unknown future value for evolvable enum patterns.</summary>
        UnknownFutureValue,
    }
}
