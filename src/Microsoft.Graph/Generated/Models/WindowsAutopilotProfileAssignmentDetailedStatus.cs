namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum WindowsAutopilotProfileAssignmentDetailedStatus {
        /// <summary>No assignment detailed status</summary>
        None,
        /// <summary>Hardware requirements are not met. This can happen if a self-deploying AutoPilot Profile is assigned to a device without TPM 2.0.</summary>
        HardwareRequirementsNotMet,
        /// <summary>Indicates that a Surface Hub AutoPilot Profile is assigned to a device that is not Surface Hub(Aruba).</summary>
        SurfaceHubProfileNotSupported,
        /// <summary>Indicates that a HoloLens AutoPilot Profile is assigned to a device that is not HoloLens.</summary>
        HoloLensProfileNotSupported,
        /// <summary>Indicates that a Windows PC AutoPilot Profile is assigned to a device that is not Windows PC.</summary>
        WindowsPcProfileNotSupported,
        /// <summary>Indicates that a surface Hub 2S  AutoPilot Profile is assigned to a device that is not surface Hub 2S.</summary>
        SurfaceHub2SProfileNotSupported,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        UnknownFutureValue,
    }
}
