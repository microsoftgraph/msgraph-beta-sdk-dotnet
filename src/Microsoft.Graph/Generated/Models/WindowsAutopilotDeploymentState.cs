namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
