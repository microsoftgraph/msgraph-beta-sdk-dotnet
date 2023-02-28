namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of tunnels that will be present to the VPN client for configuration</summary>
    public enum VpnTunnelConfigurationType {
        /// <summary>WiFi and Cellular Tunnels</summary>
        WifiAndCellular,
        /// <summary>Cellular Tunnel Only</summary>
        Cellular,
        /// <summary>WiFi Tunnel Only</summary>
        Wifi,
    }
}
