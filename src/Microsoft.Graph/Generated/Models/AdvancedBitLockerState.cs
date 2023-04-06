using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Advanced BitLocker State</summary>
    public enum AdvancedBitLockerState {
        /// <summary>Advanced BitLocker State Success</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>User never gave consent for Encryption</summary>
        [EnumMember(Value = "noUserConsent")]
        NoUserConsent,
        /// <summary>Un-protected OS Volume was detected</summary>
        [EnumMember(Value = "osVolumeUnprotected")]
        OsVolumeUnprotected,
        /// <summary>TPM not used for protection of OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmRequired")]
        OsVolumeTpmRequired,
        /// <summary>TPM only protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmOnlyRequired")]
        OsVolumeTpmOnlyRequired,
        /// <summary>TPM+PIN protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmPinRequired")]
        OsVolumeTpmPinRequired,
        /// <summary>TPM+Startup Key protection not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmStartupKeyRequired")]
        OsVolumeTpmStartupKeyRequired,
        /// <summary>TPM+PIN+Startup Key not used for OS volume, but is required by policy</summary>
        [EnumMember(Value = "osVolumeTpmPinStartupKeyRequired")]
        OsVolumeTpmPinStartupKeyRequired,
        /// <summary>Encryption method of OS Volume is different than that set by policy</summary>
        [EnumMember(Value = "osVolumeEncryptionMethodMismatch")]
        OsVolumeEncryptionMethodMismatch,
        /// <summary>Recovery key backup failed</summary>
        [EnumMember(Value = "recoveryKeyBackupFailed")]
        RecoveryKeyBackupFailed,
        /// <summary>Fixed Drive not encrypted</summary>
        [EnumMember(Value = "fixedDriveNotEncrypted")]
        FixedDriveNotEncrypted,
        /// <summary>Encryption method of Fixed Drive is different than that set by policy</summary>
        [EnumMember(Value = "fixedDriveEncryptionMethodMismatch")]
        FixedDriveEncryptionMethodMismatch,
        /// <summary>Logged on user is non-admin. This requires “AllowStandardUserEncryption” policy set to 1</summary>
        [EnumMember(Value = "loggedOnUserNonAdmin")]
        LoggedOnUserNonAdmin,
        /// <summary>WinRE is not configured</summary>
        [EnumMember(Value = "windowsRecoveryEnvironmentNotConfigured")]
        WindowsRecoveryEnvironmentNotConfigured,
        /// <summary>TPM is not available for BitLocker. This means TPM is not present, or TPM unavailable registry override is set or host OS is on portable/rome-able drive</summary>
        [EnumMember(Value = "tpmNotAvailable")]
        TpmNotAvailable,
        /// <summary>TPM is not ready for BitLocker</summary>
        [EnumMember(Value = "tpmNotReady")]
        TpmNotReady,
        /// <summary>Network not available. This is required for recovery key backup. This is reported for Drive Encryption capable devices</summary>
        [EnumMember(Value = "networkError")]
        NetworkError,
    }
}
