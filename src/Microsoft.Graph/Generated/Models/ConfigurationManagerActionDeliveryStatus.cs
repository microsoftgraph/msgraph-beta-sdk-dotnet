namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ConfigurationManagerActionDeliveryStatus {
        /// <summary>Pending to deliver the action to ConfigurationManager</summary>
        Unknown,
        /// <summary>Pending to deliver the action to ConfigurationManager</summary>
        PendingDelivery,
        /// <summary>Action is sent to ConfigurationManager Connector service (cloud)</summary>
        DeliveredToConnectorService,
        /// <summary>Failed to send the action to ConfigurationManager Connector service (cloud)</summary>
        FailedToDeliverToConnectorService,
        /// <summary>Action is delivered to ConfigurationManager on-prem server</summary>
        DeliveredToOnPremisesServer,
    }
}
