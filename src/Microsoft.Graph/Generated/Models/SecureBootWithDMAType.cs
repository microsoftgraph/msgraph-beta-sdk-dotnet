namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum SecureBootWithDMAType {
        /// <summary>Not configured, no operation</summary>
        NotConfigured,
        /// <summary>Turns on VBS with Secure Boot</summary>
        WithoutDMA,
        /// <summary>Turns on VBS with Secure Boot and DMA</summary>
        WithDMA,
    }
}
