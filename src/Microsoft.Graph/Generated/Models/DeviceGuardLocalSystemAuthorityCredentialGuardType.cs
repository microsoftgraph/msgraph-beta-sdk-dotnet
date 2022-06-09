namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardType {
        /// <summary>Turns off Credential Guard remotely if configured previously without UEFI Lock.</summary>
        NotConfigured,
        /// <summary>Turns on Credential Guard with UEFI lock.</summary>
        EnableWithUEFILock,
        /// <summary>Turns on Credential Guard without UEFI lock.</summary>
        EnableWithoutUEFILock,
        /// <summary>Disables Credential Guard. This is the default OS value.</summary>
        Disable,
    }
}
