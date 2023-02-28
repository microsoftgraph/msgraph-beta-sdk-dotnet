namespace Microsoft.Graph.Beta.Models {
    /// <summary>Deployment states for Autopilot devices</summary>
    public enum WindowsAutopilotDeploymentState {
        /// <summary>The deployment state is unknown.</summary>
        Unknown,
        /// <summary>The deployment succeeded.</summary>
        Success,
        /// <summary>The deployment state is in progress.</summary>
        InProgress,
        /// <summary>The deployment failed.</summary>
        Failure,
        /// <summary>The deployment timed out but user clicked past failure.</summary>
        SuccessWithTimeout,
        /// <summary>The deployment was not run.</summary>
        NotAttempted,
        /// <summary>The deployment is disabled.</summary>
        Disabled,
        /// <summary>The deployment succeeded after hitting an initial timeout failure.</summary>
        SuccessOnRetry,
    }
}
