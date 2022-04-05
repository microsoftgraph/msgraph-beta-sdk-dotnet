namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum RemediationState {
        Unknown,
        Skipped,
        Success,
        RemediationFailed,
        ScriptError,
    }
}
