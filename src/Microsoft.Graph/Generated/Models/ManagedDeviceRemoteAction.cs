namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the executeAction method.</summary>
    public enum ManagedDeviceRemoteAction {
        Retire,
        Delete,
        FullScan,
        QuickScan,
        SignatureUpdate,
        Wipe,
        CustomTextNotification,
        RebootNow,
        SetDeviceName,
        SyncDevice,
        /// <summary>Name of the deprovision action.</summary>
        Deprovision,
        /// <summary>Name of the disable action.</summary>
        Disable,
        /// <summary>Name of the reenable action.</summary>
        Reenable,
        /// <summary>Name of the moveDevicesToOU action.</summary>
        MoveDeviceToOrganizationalUnit,
        /// <summary>Name of action to Activate eSIM on the device.</summary>
        ActivateDeviceEsim,
        /// <summary>Name of the collectDiagnostics action.</summary>
        CollectDiagnostics,
    }
}
