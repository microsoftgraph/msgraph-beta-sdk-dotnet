namespace Microsoft.Graph.Beta.Models {
    /// <summary>Certificate Revocation Status.</summary>
    public enum CertificateRevocationStatus {
        /// <summary>Not revoked.</summary>
        None,
        /// <summary>Revocation pending.</summary>
        Pending,
        /// <summary>Revocation command issued.</summary>
        Issued,
        /// <summary>Revocation failed.</summary>
        Failed,
        /// <summary>Revoked.</summary>
        Revoked,
    }
}
