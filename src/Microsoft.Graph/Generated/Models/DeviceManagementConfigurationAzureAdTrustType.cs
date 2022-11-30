namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementConfigurationAzureAdTrustType {
        /// <summary>No AAD Trust Type specified</summary>
        None,
        /// <summary>AAD Joined Trust Type</summary>
        AzureAdJoined,
        /// <summary>AddWorkAccount</summary>
        AddWorkAccount,
        /// <summary>MDM only</summary>
        MdmOnly,
    }
}
