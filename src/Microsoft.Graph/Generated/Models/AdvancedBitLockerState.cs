namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AdvancedBitLockerState {
        /// <summary>Advanced BitLocker State Success</summary>
        Success,
        /// <summary>User never gave consent for Encryption</summary>
        NoUserConsent,
        /// <summary>Un-protected OS Volume was detected</summary>
        OsVolumeUnprotected,
        /// <summary>TPM not used for protection of OS volume, but is required by policy</summary>
        OsVolumeTpmRequired,
        /// <summary>TPM only protection not used for OS volume, but is required by policy</summary>
        OsVolumeTpmOnlyRequired,
        /// <summary>TPM+PIN protection not used for OS volume, but is required by policy</summary>
        OsVolumeTpmPinRequired,
        /// <summary>TPM+Startup Key protection not used for OS volume, but is required by policy</summary>
        OsVolumeTpmStartupKeyRequired,
        /// <summary>TPM+PIN+Startup Key not used for OS volume, but is required by policy</summary>
        OsVolumeTpmPinStartupKeyRequired,
        /// <summary>Encryption method of OS Volume is different than that set by policy</summary>
        OsVolumeEncryptionMethodMismatch,
        /// <summary>Recovery key backup failed</summary>
        RecoveryKeyBackupFailed,
        /// <summary>Fixed Drive not encrypted</summary>
        FixedDriveNotEncrypted,
        /// <summary>Encryption method of Fixed Drive is different than that set by policy</summary>
        FixedDriveEncryptionMethodMismatch,
        /// <summary>Logged on user is non-admin. This requires “AllowStandardUserEncryption” policy set to 1</summary>
        LoggedOnUserNonAdmin,
        /// <summary>WinRE is not configured</summary>
        WindowsRecoveryEnvironmentNotConfigured,
        /// <summary>TPM is not available for BitLocker. This means TPM is not present, or TPM unavailable registry override is set or host OS is on portable/rome-able drive</summary>
        TpmNotAvailable,
        /// <summary>TPM is not ready for BitLocker</summary>
        TpmNotReady,
        /// <summary>Network not available. This is required for recovery key backup. This is reported for Drive Encryption capable devices</summary>
        NetworkError,
    }
}
