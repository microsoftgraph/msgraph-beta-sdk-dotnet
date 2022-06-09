namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsUpdateStatus {
        /// <summary>There are no pending updates, no pending reboot updates and no failed updates.</summary>
        UpToDate,
        /// <summary>There are updates that’s pending installation which includes updates that are not approved. There are no Pending reboot updates, no failed updates.</summary>
        PendingInstallation,
        /// <summary>There are updates that requires reboot. There are not failed updates.</summary>
        PendingReboot,
        /// <summary>There are updates failed to install on the device.</summary>
        Failed,
    }
}
