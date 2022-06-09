namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidDeviceOwnerRequiredPasswordUnlock {
        /// <summary>Timeout period before strong authentication is required is set to the device&apos;s default.</summary>
        DeviceDefault,
        /// <summary>Timeout period before strong authentication is required is set to 24 hours.</summary>
        Daily,
        /// <summary>Unknown future value (reserved, not used right now)</summary>
        UnkownFutureValue,
    }
}
