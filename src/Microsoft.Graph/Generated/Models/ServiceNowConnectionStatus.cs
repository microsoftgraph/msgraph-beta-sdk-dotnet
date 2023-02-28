namespace Microsoft.Graph.Beta.Models {
    /// <summary>Status of ServiceNow Connection</summary>
    public enum ServiceNowConnectionStatus {
        /// <summary>Tenant has disabled the connection</summary>
        Disabled,
        /// <summary>Tenant has enabled the connection</summary>
        Enabled,
        /// <summary>Future authentication method to be added here.</summary>
        UnknownFutureValue,
    }
}
