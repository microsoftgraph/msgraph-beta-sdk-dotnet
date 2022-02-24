namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
