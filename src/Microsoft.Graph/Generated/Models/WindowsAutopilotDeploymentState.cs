namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsAutopilotDeploymentState {
        Unknown,
        Success,
        InProgress,
        Failure,
        SuccessWithTimeout,
        NotAttempted,
        Disabled,
    }
}
