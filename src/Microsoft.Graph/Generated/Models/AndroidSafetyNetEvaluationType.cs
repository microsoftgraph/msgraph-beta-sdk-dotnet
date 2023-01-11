namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing the Android SafetyNet attestation evaluation types.</summary>
    public enum AndroidSafetyNetEvaluationType {
        /// <summary>Default value. Typical measurements and reference data were used.</summary>
        Basic,
        /// <summary>Hardware-backed security features (such as Key Attestation) were used.</summary>
        HardwareBacked,
    }
}
