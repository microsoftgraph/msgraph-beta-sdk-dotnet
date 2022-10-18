namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum EmailCertificateType {
        /// <summary>Do not use a certificate as a source.</summary>
        None,
        /// <summary>Use an certificate for certificate source.</summary>
        Certificate,
        /// <summary>Use a derived credential for certificate source.</summary>
        DerivedCredential,
    }
}
