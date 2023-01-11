namespace Microsoft.Graph.Beta.Models {
    /// <summary>The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.</summary>
    public enum ManagedAppPhoneNumberRedirectLevel {
        /// <summary>Sharing is allowed to all apps.</summary>
        AllApps,
        /// <summary>Sharing is allowed to all managed apps.</summary>
        ManagedApps,
        /// <summary>Sharing is allowed to a custom app.</summary>
        CustomApp,
        /// <summary>Sharing between apps is blocked.</summary>
        Blocked,
    }
}
