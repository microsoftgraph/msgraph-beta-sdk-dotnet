namespace Microsoft.Graph.Beta.Models {
    /// <summary>Connector health state for connector status</summary>
    public enum ConnectorHealthState {
        /// <summary>Indicates a healthy connector status and no action required.</summary>
        Healthy,
        /// <summary>Indicates that a connector needs attention.</summary>
        Warning,
        /// <summary>Indicates that a connector needs immediate attention to retain functionality.</summary>
        Unhealthy,
        /// <summary>unknown</summary>
        Unknown,
    }
}
