namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ResultantAppState {
        /// <summary>The application is not applicable.</summary>
        NotApplicable,
        /// <summary>The application is installed with no errors.</summary>
        Installed,
        /// <summary>The application failed to install.</summary>
        Failed,
        /// <summary>The application is not installed.</summary>
        NotInstalled,
        /// <summary>The application failed to uninstall.</summary>
        UninstallFailed,
        /// <summary>The installation of the application is in progress.</summary>
        PendingInstall,
        /// <summary>The status of the application is unknown.</summary>
        Unknown,
    }
}
