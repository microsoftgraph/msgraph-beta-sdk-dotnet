namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum WindowsAutopilotDeviceRemediationState {
        /// <summary>Unknown status.</summary>
        Unknown,
        /// <summary>No hardware change has been detected.</summary>
        NoRemediationRequired,
        /// <summary>Hardware change detected on client. Additional remediation is required.</summary>
        AutomaticRemediationRequired,
        /// <summary>Hardware change detected on client that could not resolved automatically. Additional remediation is required.</summary>
        ManualRemediationRequired,
        /// <summary>Marks the end of known enum values, and allows for additional values in the future.</summary>
        UnknownFutureValue,
    }
}
