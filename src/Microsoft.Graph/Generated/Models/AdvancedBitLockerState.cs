namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AdvancedBitLockerState {
        Success,
        NoUserConsent,
        OsVolumeUnprotected,
        OsVolumeTpmRequired,
        OsVolumeTpmOnlyRequired,
        OsVolumeTpmPinRequired,
        OsVolumeTpmStartupKeyRequired,
        OsVolumeTpmPinStartupKeyRequired,
        OsVolumeEncryptionMethodMismatch,
        RecoveryKeyBackupFailed,
        FixedDriveNotEncrypted,
        FixedDriveEncryptionMethodMismatch,
        LoggedOnUserNonAdmin,
        WindowsRecoveryEnvironmentNotConfigured,
        TpmNotAvailable,
        TpmNotReady,
        NetworkError,
    }
}
