namespace Microsoft.Graph.Beta.Models {
    /// <summary>Flags representing which network profile types apply to a firewall rule.</summary>
    public enum WindowsFirewallRuleNetworkProfileTypes {
        /// <summary>No flags set.</summary>
        NotConfigured,
        /// <summary>The profile for networks that are connected to domains.</summary>
        Domain,
        /// <summary>The profile for private networks.</summary>
        Private,
        /// <summary>The profile for public networks.</summary>
        Public,
    }
}
