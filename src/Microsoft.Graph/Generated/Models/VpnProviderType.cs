namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provider type for per-app VPN.</summary>
    public enum VpnProviderType {
        /// <summary>Tunnel traffic is not explicitly configured.</summary>
        NotConfigured,
        /// <summary>Tunnel traffic at the application layer.</summary>
        AppProxy,
        /// <summary>Tunnel traffic at the IP layer.</summary>
        PacketTunnel,
    }
}
