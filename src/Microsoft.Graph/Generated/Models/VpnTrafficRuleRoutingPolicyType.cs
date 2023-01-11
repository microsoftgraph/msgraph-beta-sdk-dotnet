namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specifies the routing policy for a VPN traffic rule.</summary>
    public enum VpnTrafficRuleRoutingPolicyType {
        /// <summary>No routing policy specified.</summary>
        None,
        /// <summary>Network traffic for the specified app will be routed through the VPN.</summary>
        SplitTunnel,
        /// <summary>All network traffic will be routed through the VPN.</summary>
        ForceTunnel,
    }
}
