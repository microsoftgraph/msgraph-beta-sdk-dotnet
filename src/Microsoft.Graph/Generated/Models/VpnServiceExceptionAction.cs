namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum VpnServiceExceptionAction {
        /// <summary>Make all traffic from that service go through the VPN</summary>
        ForceTrafficViaVPN,
        /// <summary>Allow the service outside of the VPN</summary>
        AllowTrafficOutside,
        /// <summary>Drop all traffic from the service</summary>
        DropTraffic,
    }
}
