namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum RemediationState {
        /// <summary>Unknown result.</summary>
        Unknown,
        /// <summary>Remediation script execution was skipped</summary>
        Skipped,
        /// <summary>Remediation script executed successfully and remediated the device state</summary>
        Success,
        /// <summary>Remediation script executed successfully but failed to remediated the device state</summary>
        RemediationFailed,
        /// <summary>Remediation script execution encountered and error or timed out</summary>
        ScriptError,
    }
}
