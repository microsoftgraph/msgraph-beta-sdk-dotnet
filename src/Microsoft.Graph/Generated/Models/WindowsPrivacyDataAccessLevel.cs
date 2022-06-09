namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsPrivacyDataAccessLevel {
        /// <summary>No access level specified, no intents. Device may behave either as in UserInControl or ForceAllow. It may depend on the privacy data been accessed, Windows versions and other factors.</summary>
        NotConfigured,
        /// <summary>Apps will be allowed to access the specified privacy data.</summary>
        ForceAllow,
        /// <summary>Apps will be denied to access specified privacy data.</summary>
        ForceDeny,
        /// <summary>Users will be prompted when apps try to access specified privacy data.</summary>
        UserInControl,
    }
}
