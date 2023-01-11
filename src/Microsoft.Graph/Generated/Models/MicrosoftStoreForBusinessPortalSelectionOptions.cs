namespace Microsoft.Graph.Beta.Models {
    /// <summary>Portal to which admin syncs available Microsoft Store for Business apps. This is available in the Intune Admin Console.</summary>
    public enum MicrosoftStoreForBusinessPortalSelectionOptions {
        /// <summary>This option is not available for the account</summary>
        None,
        /// <summary>Intune Company Portal only.</summary>
        CompanyPortal,
        /// <summary>MSFB Private store only.</summary>
        PrivateStore,
    }
}
