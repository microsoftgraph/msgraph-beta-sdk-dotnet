namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public enum RoutingPolicy {
        None,
        NoMissedCall,
        DisableForwardingExceptPhone,
        DisableForwarding,
        PreferSkypeForBusiness,
        UnknownFutureValue,
    }
}
