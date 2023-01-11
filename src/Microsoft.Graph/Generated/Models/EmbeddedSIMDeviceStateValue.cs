namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes the various states for an embedded SIM activation code.</summary>
    public enum EmbeddedSIMDeviceStateValue {
        /// <summary>Designates that the embedded SIM activation code is free and available to be assigned to a device.</summary>
        NotEvaluated,
        /// <summary>Designates that Intune Service failed to deliver this profile to a device.</summary>
        Failed,
        /// <summary>Designates that the embedded SIM activation code has been assigned to a device and the device is installing the token.</summary>
        Installing,
        /// <summary>Designates that the embedded SIM activation code has been successfully installed on the target device.</summary>
        Installed,
        /// <summary>Designates that Intune Service is trying to delete the profile from the device.</summary>
        Deleting,
        /// <summary>Designates that there is error with this profile.</summary>
        Error,
        /// <summary>Designates that the profile is deleted from the device.</summary>
        Deleted,
        /// <summary>Designates that the profile is removed from the device by the user</summary>
        RemovedByUser,
    }
}
