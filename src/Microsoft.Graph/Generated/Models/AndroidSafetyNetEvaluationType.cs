namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidSafetyNetEvaluationType {
        /// <summary>Default value. Typical measurements and reference data were used.</summary>
        Basic,
        /// <summary>Hardware-backed security features (such as Key Attestation) were used.</summary>
        HardwareBacked,
    }
}
