namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum SharedPCAllowedAccountType {
        /// <summary>Not configured. Default value.</summary>
        NotConfigured,
        /// <summary>Only guest accounts.</summary>
        Guest,
        /// <summary>Only domain-joined accounts.</summary>
        Domain,
    }
}
