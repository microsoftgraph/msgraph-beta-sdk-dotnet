namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum VpnProviderType {
        /// <summary>Tunnel traffic is not explicitly configured.</summary>
        NotConfigured,
        /// <summary>Tunnel traffic at the application layer.</summary>
        AppProxy,
        /// <summary>Tunnel traffic at the IP layer.</summary>
        PacketTunnel,
    }
}
