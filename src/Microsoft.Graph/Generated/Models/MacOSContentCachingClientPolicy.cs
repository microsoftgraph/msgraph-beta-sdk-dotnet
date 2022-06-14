namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum MacOSContentCachingClientPolicy {
        /// <summary>Defaults to clients in local network.</summary>
        NotConfigured,
        /// <summary>Content caches will provide content to devices only in their immediate local network.</summary>
        ClientsInLocalNetwork,
        /// <summary>Content caches will provide content to devices that share the same public IP address.</summary>
        ClientsWithSamePublicIpAddress,
        /// <summary>Content caches will provide content to devices in contentCachingClientListenRanges.</summary>
        ClientsInCustomLocalNetworks,
        /// <summary>Content caches will provide content to devices in contentCachingClientListenRanges, contentCachingPeerListenRanges, and contentCachingParents.</summary>
        ClientsInCustomLocalNetworksWithFallback,
    }
}
