namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum Windows10VpnConnectionType {
        /// <summary>Pulse Secure.</summary>
        PulseSecure,
        /// <summary>F5 Edge Client.</summary>
        F5EdgeClient,
        /// <summary>Dell SonicWALL Mobile Connection.</summary>
        DellSonicWallMobileConnect,
        /// <summary>Check Point Capsule VPN.</summary>
        CheckPointCapsuleVpn,
        /// <summary>Automatic.</summary>
        Automatic,
        /// <summary>IKEv2.</summary>
        IkEv2,
        /// <summary>L2TP.</summary>
        L2tp,
        /// <summary>PPTP.</summary>
        Pptp,
        /// <summary>Citrix.</summary>
        Citrix,
        /// <summary>Palo Alto Networks GlobalProtect.</summary>
        PaloAltoGlobalProtect,
        /// <summary>Cisco AnyConnect</summary>
        CiscoAnyConnect,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
        /// <summary>Microsoft Tunnel connection type</summary>
        MicrosoftTunnel,
    }
}
