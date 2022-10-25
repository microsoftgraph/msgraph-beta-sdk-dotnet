namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum RemoteAction {
        /// <summary>Indicate user initiates an unknown action.</summary>
        Unknown,
        /// <summary>Indicate user initiates an action to factory reset a device. </summary>
        FactoryReset,
        /// <summary>Indicate user initiates an action to remove company data from a device. </summary>
        RemoveCompanyData,
        /// <summary>Indicate user initiates an action to remove the passcode of an iOS device, or reset the passcode of Android / Windows device. </summary>
        ResetPasscode,
        /// <summary>Indicate user initiates an action to remote lock a device.</summary>
        RemoteLock,
        /// <summary>Indicate user initiates an action to enable lost mode on a supervised iOS device.</summary>
        EnableLostMode,
        /// <summary>Indicate user initiates an action to disable lost mode on a supervised iOS device.</summary>
        DisableLostMode,
        /// <summary>Indicate user initiates an action to locate a supervised iOS device.</summary>
        LocateDevice,
        /// <summary>Indicate user initiates an action to reboot the device.</summary>
        RebootNow,
        /// <summary>Indicate user initiates an action to reset the pin for passport for work on windows phone device.</summary>
        RecoverPasscode,
        /// <summary>Indicate user initiates an action to clean up windows device.</summary>
        CleanWindowsDevice,
        /// <summary>Indicate user initiates an action to log out current user on shared apple device.</summary>
        LogoutSharedAppleDeviceActiveUser,
        /// <summary>Indicate user initiates an action to run quick scan on device.</summary>
        QuickScan,
        /// <summary>Indicate user initiates an action to run full scan on device.</summary>
        FullScan,
        /// <summary>Indicate user initiates an action to update malware signatures on device.</summary>
        WindowsDefenderUpdateSignatures,
        /// <summary>Indicate user initiates an action remote wipe device with keeping enrollment data.</summary>
        FactoryResetKeepEnrollmentData,
        /// <summary>Indicate user initiates an action to update account on device.</summary>
        UpdateDeviceAccount,
        /// <summary>Indicate user initiates an action to automatic redeploy the device</summary>
        AutomaticRedeployment,
        /// <summary>Indicate user initiates an action to shut down the device.</summary>
        ShutDown,
        /// <summary>Indicate user initiates an action to Rotate BitLockerKeys on the device.</summary>
        RotateBitLockerKeys,
        /// <summary>Indicate user initiates an action to Rotate FileVaultKey on mac.</summary>
        RotateFileVaultKey,
        /// <summary>Indicate user initiates an action to Get FileVaultKey on mac.</summary>
        GetFileVaultKey,
        /// <summary>Indicate user initiates an action to Set Device Name on the device.</summary>
        SetDeviceName,
        /// <summary>Indicate user initiates an action to Activate eSIM on the device.</summary>
        ActivateDeviceEsim,
        /// <summary>Indicate user initiates an action to deprovision the device.</summary>
        Deprovision,
        /// <summary>Indicate user initiates an action to disable the device.</summary>
        Disable,
        /// <summary>Indicate user initiates an action to reenable the device.</summary>
        Reenable,
        /// <summary>Indicate user initiates an action to move the device to a new organizational unit.</summary>
        MoveDeviceToOrganizationalUnit,
    }
}
