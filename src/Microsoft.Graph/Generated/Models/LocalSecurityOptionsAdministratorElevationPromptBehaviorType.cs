namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum LocalSecurityOptionsAdministratorElevationPromptBehaviorType {
        /// <summary>Not Configured</summary>
        NotConfigured,
        /// <summary>Elevate without prompting.</summary>
        ElevateWithoutPrompting,
        /// <summary>Prompt for credentials on the secure desktop</summary>
        PromptForCredentialsOnTheSecureDesktop,
        /// <summary>Prompt for consent on the secure desktop</summary>
        PromptForConsentOnTheSecureDesktop,
        /// <summary>Prompt for credentials</summary>
        PromptForCredentials,
        /// <summary>Prompt for consent</summary>
        PromptForConsent,
        /// <summary>Prompt for consent for non-Windows binaries</summary>
        PromptForConsentForNonWindowsBinaries,
    }
}
