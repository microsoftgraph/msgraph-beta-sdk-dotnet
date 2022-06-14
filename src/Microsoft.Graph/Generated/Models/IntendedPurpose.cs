namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum IntendedPurpose {
        /// <summary>Unassigned</summary>
        Unassigned,
        /// <summary>SmimeEncryption</summary>
        SmimeEncryption,
        /// <summary>SmimeSigning</summary>
        SmimeSigning,
        /// <summary>VPN</summary>
        Vpn,
        /// <summary>Wifi</summary>
        Wifi,
    }
}
