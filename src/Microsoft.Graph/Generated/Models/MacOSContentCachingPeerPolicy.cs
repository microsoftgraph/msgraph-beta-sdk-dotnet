namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines which content caches other content caches will peer with.</summary>
    public enum MacOSContentCachingPeerPolicy {
        /// <summary>Defaults to peers in local network.</summary>
        NotConfigured,
        /// <summary>Content caches will only peer with caches in their immediate local network.</summary>
        PeersInLocalNetwork,
        /// <summary>Content caches will only peer with caches that share the same public IP address.</summary>
        PeersWithSamePublicIpAddress,
        /// <summary>Content caches will use contentCachingPeerFilterRanges and contentCachingPeerListenRanges to determine which caches to peer with.</summary>
        PeersInCustomLocalNetworks,
    }
}
