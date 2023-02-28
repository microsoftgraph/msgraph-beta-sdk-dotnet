namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsStandardUserElevationPromptBehavior</summary>
    public enum LocalSecurityOptionsStandardUserElevationPromptBehaviorType {
        /// <summary>Not Configured</summary>
        NotConfigured,
        /// <summary>Automatically deny elevation requests</summary>
        AutomaticallyDenyElevationRequests,
        /// <summary>Prompt for credentials on the secure desktop</summary>
        PromptForCredentialsOnTheSecureDesktop,
        /// <summary>Prompt for credentials</summary>
        PromptForCredentials,
    }
}
