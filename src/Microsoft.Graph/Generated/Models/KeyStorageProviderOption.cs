namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum KeyStorageProviderOption {
        /// <summary>Import to Trusted Platform Module (TPM) KSP if present, otherwise import to Software KSP.</summary>
        UseTpmKspOtherwiseUseSoftwareKsp,
        /// <summary>Import to Trusted Platform Module (TPM) KSP if present, otherwise fail.</summary>
        UseTpmKspOtherwiseFail,
        /// <summary>Import to Passport for work KSP if available, otherwise fail.</summary>
        UsePassportForWorkKspOtherwiseFail,
        /// <summary>Import to Software KSP.</summary>
        UseSoftwareKsp,
    }
}
