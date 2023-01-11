namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defines the permission level granted to users to enable them change Uefi settings</summary>
    public enum ChangeUefiSettingsPermission {
        /// <summary>Device default value, no intent.</summary>
        NotConfiguredOnly,
        /// <summary>Prevent change of UEFI setting permission</summary>
        None,
    }
}
