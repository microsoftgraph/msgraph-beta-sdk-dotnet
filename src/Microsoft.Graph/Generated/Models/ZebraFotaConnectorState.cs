namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum ZebraFotaConnectorState {
        /// <summary>Default value when the connector has not been setup (the feature has not been used yet).</summary>
        None,
        /// <summary>Connected state indicates that Intune is linked to Zebra Update Services for the current tenant.</summary>
        Connected,
        /// <summary>Disconnected state indicates that the account was connected in the past and later disconnected.</summary>
        Disconnected,
        /// <summary>Unknown future enum value.</summary>
        UnknownFutureValue,
    }
}
