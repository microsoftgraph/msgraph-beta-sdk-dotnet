namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum RemoteAction {
        /// <summary>User initiates an unknown action.</summary>
        Unknown,
        /// <summary>User initiates an action to factory reset a device. </summary>
        FactoryReset,
        /// <summary>User initiates an action to remove company data from a device. </summary>
        RemoveCompanyData,
        /// <summary>User initiates an action to remove the passcode of an iOS device, or reset the passcode of Android / Windows device. </summary>
        ResetPasscode,
        /// <summary>User initiates an action to remote lock a device.</summary>
        RemoteLock,
        /// <summary>User initiates an action to enable lost mode on a supervised iOS device.</summary>
        EnableLostMode,
        /// <summary>User initiates an action to disable lost mode on a supervised iOS device.</summary>
        DisableLostMode,
        /// <summary>User initiates an action to locate a supervised iOS device.</summary>
        LocateDevice,
        /// <summary>User initiates an action to reboot a Windows device.</summary>
        RebootNow,
        /// <summary>User initiates an action to reset the pin for passport for work on windows phone device.</summary>
        RecoverPasscode,
        /// <summary>User initiates an action to clean up windows device.</summary>
        CleanWindowsDevice,
        /// <summary>User initiates an action to log out current user on shared apple device.</summary>
        LogoutSharedAppleDeviceActiveUser,
        /// <summary>User initiates an action to run quick scan on device.</summary>
        QuickScan,
        /// <summary>User initiates an action to run full scan on device.</summary>
        FullScan,
        /// <summary>User initiates an action to update malware signatures on device.</summary>
        WindowsDefenderUpdateSignatures,
        /// <summary>User initiates an action remote wipe device with keeping enrollment data.</summary>
        FactoryResetKeepEnrollmentData,
        /// <summary>User initiates an action to update account on device.</summary>
        UpdateDeviceAccount,
        /// <summary>User initiates an action to automatice redeploy the device</summary>
        AutomaticRedeployment,
        /// <summary>User initiates an action to shut down the device.</summary>
        ShutDown,
        /// <summary>User initiates an action to Rotate BitLockerKeys on the device.</summary>
        RotateBitLockerKeys,
        /// <summary>User initiates an action to Rotate FileVaultKey on mac.</summary>
        RotateFileVaultKey,
        /// <summary>User initiates an action to Get FileVaultKey on mac.</summary>
        GetFileVaultKey,
        /// <summary>User initiates an action to Set Device Name on the device.</summary>
        SetDeviceName,
        /// <summary>User initiates an action to Activate eSIM on the device.</summary>
        ActivateDeviceEsim,
    }
}
