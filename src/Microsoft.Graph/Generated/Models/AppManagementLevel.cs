namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum AppManagementLevel {
        /// <summary>Unspecified</summary>
        Unspecified,
        /// <summary>Unmanaged</summary>
        Unmanaged,
        /// <summary>MDM</summary>
        Mdm,
        /// <summary>Android Enterprise</summary>
        AndroidEnterprise,
        /// <summary>Android Enterprise dedicated devices with Azure AD Shared mode</summary>
        AndroidEnterpriseDedicatedDevicesWithAzureAdSharedMode,
        /// <summary>Android Open Source Project (AOSP) devices</summary>
        AndroidOpenSourceProjectUserAssociated,
        /// <summary>Android Open Source Project (AOSP) userless devices</summary>
        AndroidOpenSourceProjectUserless,
        /// <summary>Place holder for evolvable enum</summary>
        UnknownFutureValue,
    }
}
