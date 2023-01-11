namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of accounts that are allowed to share the PC.</summary>
    public enum SharedPCAllowedAccountType {
        /// <summary>Not configured. Default value.</summary>
        NotConfigured,
        /// <summary>Only guest accounts.</summary>
        Guest,
        /// <summary>Only domain-joined accounts.</summary>
        Domain,
    }
}
