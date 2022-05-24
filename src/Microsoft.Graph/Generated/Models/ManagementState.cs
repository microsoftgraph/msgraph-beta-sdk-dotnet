namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public enum ManagementState {
        /// <summary>The device is under management</summary>
        Managed,
        /// <summary>A retire command is occuring on the device and in the process of unenrolling from management</summary>
        RetirePending,
        /// <summary>Retire command failed on the device</summary>
        RetireFailed,
        /// <summary>A wipe command is occuring on the device and in the process of unenrolling from management</summary>
        WipePending,
        /// <summary>Wipe command failed on the device</summary>
        WipeFailed,
        /// <summary>The device is unhealthy.</summary>
        Unhealthy,
        /// <summary>A delete command is occuring on the device </summary>
        DeletePending,
        /// <summary>A retire command was issued for the device</summary>
        RetireIssued,
        /// <summary>A wipe command was issued for the device</summary>
        WipeIssued,
        /// <summary>A wipe command for this device has been canceled</summary>
        WipeCanceled,
        /// <summary>A retire command for this device has been canceled</summary>
        RetireCanceled,
        /// <summary>The device is discovered but not fully enrolled.</summary>
        Discovered,
    }
}
