namespace Microsoft.Graph.Beta.Models {
    /// <summary>Recovery key types for macOS FileVault</summary>
    public enum MacOSFileVaultRecoveryKeyTypes {
        /// <summary>Device default value, no intent.</summary>
        NotConfigured,
        /// <summary>An institutional recovery key is like a “master” recovery key that can be used to unlock any device whose password has been lost.</summary>
        InstitutionalRecoveryKey,
        /// <summary>A personal recovery key is a unique code that can be used to unlock the user’s device, even if the password to the device is lost.</summary>
        PersonalRecoveryKey,
    }
}
