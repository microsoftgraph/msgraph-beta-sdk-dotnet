namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementExchangeAccessLevel {
        /// <summary>No device access rule has been configured in Exchange.</summary>
        None,
        /// <summary>Allow the device access to Exchange.</summary>
        Allow,
        /// <summary>Block the device from accessing Exchange.</summary>
        Block,
        /// <summary>Quarantine the device in Exchange.</summary>
        Quarantine,
    }
}
