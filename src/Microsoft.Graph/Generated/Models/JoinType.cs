namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum JoinType {
        /// <summary>Unknown enrollment join type.</summary>
        Unknown,
        /// <summary>The device is joined by Azure AD.</summary>
        AzureADJoined,
        /// <summary>The device is registered by Azure AD.</summary>
        AzureADRegistered,
        /// <summary>The device is joined by hybrid Azure AD.</summary>
        HybridAzureADJoined,
    }
}
