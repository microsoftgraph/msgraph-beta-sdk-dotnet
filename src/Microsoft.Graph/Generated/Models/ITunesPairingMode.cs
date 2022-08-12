namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum ITunesPairingMode {
        /// <summary>Pairing is not allowed</summary>
        Disallow,
        /// <summary>Pairing allowed</summary>
        Allow,
        /// <summary>Certificate required to pair with iTunes</summary>
        RequiresCertificate,
    }
}
