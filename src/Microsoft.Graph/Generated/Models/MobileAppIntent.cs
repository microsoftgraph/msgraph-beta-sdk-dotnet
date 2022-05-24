namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public enum MobileAppIntent {
        /// <summary>Available</summary>
        Available,
        /// <summary>Not Available</summary>
        NotAvailable,
        /// <summary>Required Install</summary>
        RequiredInstall,
        /// <summary>Required Uninstall</summary>
        RequiredUninstall,
        /// <summary>RequiredAndAvailableInstall</summary>
        RequiredAndAvailableInstall,
        /// <summary>AvailableInstallWithoutEnrollment</summary>
        AvailableInstallWithoutEnrollment,
        /// <summary>Exclude</summary>
        Exclude,
    }
}
