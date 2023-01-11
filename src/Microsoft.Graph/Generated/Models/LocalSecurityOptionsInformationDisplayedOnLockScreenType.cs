namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsInformationDisplayedOnLockScreen</summary>
    public enum LocalSecurityOptionsInformationDisplayedOnLockScreenType {
        /// <summary>Not Configured</summary>
        NotConfigured,
        /// <summary>User display name, domain and user names</summary>
        Administrators,
        /// <summary>User display name only</summary>
        AdministratorsAndPowerUsers,
        /// <summary>Do not display user information</summary>
        AdministratorsAndInteractiveUsers,
    }
}
