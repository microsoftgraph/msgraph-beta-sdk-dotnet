namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum FileVaultState {
        /// <summary>FileVault State Success</summary>
        Success,
        /// <summary>FileVault has been enabled by user and is not being managed by policy</summary>
        DriveEncryptedByUser,
        /// <summary>FileVault policy is successfully installed but user has not started encryption</summary>
        UserDeferredEncryption,
        /// <summary>FileVault recovery key escrow is not enabled</summary>
        EscrowNotEnabled,
    }
}
