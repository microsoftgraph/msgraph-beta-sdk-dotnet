namespace Microsoft.Graph.Beta.Models {
    /// <summary>The VPN action to take for a specific service.</summary>
    public enum VpnServiceExceptionAction {
        /// <summary>Make all traffic from that service go through the VPN</summary>
        ForceTrafficViaVPN,
        /// <summary>Allow the service outside of the VPN</summary>
        AllowTrafficOutside,
        /// <summary>Drop all traffic from the service</summary>
        DropTraffic,
    }
}
