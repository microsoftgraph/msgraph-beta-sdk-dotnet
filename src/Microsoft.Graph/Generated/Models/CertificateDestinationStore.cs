namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum CertificateDestinationStore {
        /// <summary>Computer Certificate Store - Root.</summary>
        ComputerCertStoreRoot,
        /// <summary>Computer Certificate Store - Intermediate.</summary>
        ComputerCertStoreIntermediate,
        /// <summary>User Certificate Store - Intermediate.</summary>
        UserCertStoreIntermediate,
    }
}
