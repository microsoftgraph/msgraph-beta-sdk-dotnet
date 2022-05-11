namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum AndroidDeviceOwnerEnrollmentTokenType {
        /// <summary>Default token type.</summary>
        Default,
        /// <summary>Token type for Azure AD shared dedicated device enrollment. It applies to CorporateOwnedDedicatedDevice enrollment mode only.</summary>
        CorporateOwnedDedicatedDeviceWithAzureADSharedMode,
    }
}
