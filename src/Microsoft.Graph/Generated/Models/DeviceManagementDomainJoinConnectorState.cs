namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementDomainJoinConnectorState {
        /// <summary>Connector is actively pinging Intune.</summary>
        Active,
        /// <summary>There is no heart-beat from connector from last one hour.</summary>
        Error,
        /// <summary>There is no heart-beat from connector from last 5 days.</summary>
        Inactive,
    }
}
