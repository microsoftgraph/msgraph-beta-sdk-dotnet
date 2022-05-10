namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum UserPfxIntendedPurpose {
        /// <summary>No roles/usages assigned.</summary>
        Unassigned,
        /// <summary>Valid for S/MIME encryption.</summary>
        SmimeEncryption,
        /// <summary>Valid for S/MIME signing.</summary>
        SmimeSigning,
        /// <summary>Valid for use in VPN.</summary>
        Vpn,
        /// <summary>Valid for use in WiFi.</summary>
        Wifi,
    }
}
