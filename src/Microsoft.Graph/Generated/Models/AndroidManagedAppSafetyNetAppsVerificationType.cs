namespace Microsoft.Graph.Beta.Models {
    /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
    public enum AndroidManagedAppSafetyNetAppsVerificationType {
        /// <summary>no requirement set</summary>
        None,
        /// <summary>require that Android device has SafetyNet Apps Verification enabled</summary>
        Enabled,
    }
}
