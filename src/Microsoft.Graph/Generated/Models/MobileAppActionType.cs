namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defines the Action Types for an Intune Application.</summary>
    public enum MobileAppActionType {
        /// <summary>Unknown result.</summary>
        Unknown,
        /// <summary>Application install command was sent.</summary>
        InstallCommandSent,
        /// <summary>Application installed.</summary>
        Installed,
        /// <summary>Application uninstalled.</summary>
        Uninstalled,
        /// <summary>User requested installation</summary>
        UserRequestedInstall,
    }
}
