namespace Microsoft.Graph.Beta.Models {
    /// <summary>Required AAD Trust Type</summary>
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
