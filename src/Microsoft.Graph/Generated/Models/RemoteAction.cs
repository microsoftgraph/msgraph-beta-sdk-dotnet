namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum RemoteAction {
        Unknown,
        FactoryReset,
        RemoveCompanyData,
        ResetPasscode,
        RemoteLock,
        EnableLostMode,
        DisableLostMode,
        LocateDevice,
        RebootNow,
        RecoverPasscode,
        CleanWindowsDevice,
        LogoutSharedAppleDeviceActiveUser,
        QuickScan,
        FullScan,
        WindowsDefenderUpdateSignatures,
        FactoryResetKeepEnrollmentData,
        UpdateDeviceAccount,
        AutomaticRedeployment,
        ShutDown,
        RotateBitLockerKeys,
        RotateFileVaultKey,
        GetFileVaultKey,
        SetDeviceName,
        ActivateDeviceEsim,
    }
}
