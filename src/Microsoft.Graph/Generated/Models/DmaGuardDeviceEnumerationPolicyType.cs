namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DmaGuardDeviceEnumerationPolicyType {
        /// <summary>Default value. Devices with DMA remapping incompatible drivers will only be enumerated after the user unlocks the screen.</summary>
        DeviceDefault,
        /// <summary>Devices with DMA remapping incompatible drivers will never be allowed to start and perform DMA at any time.</summary>
        BlockAll,
        /// <summary>All external DMA capable PCIe devices will be enumerated at any time.</summary>
        AllowAll,
    }
}
