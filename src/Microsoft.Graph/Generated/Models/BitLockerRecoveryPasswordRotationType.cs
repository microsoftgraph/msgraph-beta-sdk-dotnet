namespace Microsoft.Graph.Beta.Models {
    /// <summary>BitLocker recovery password rotation type</summary>
    public enum BitLockerRecoveryPasswordRotationType {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Recovery password rotation off</summary>
        Disabled,
        /// <summary>Recovery password rotation on for Azure AD joined devices</summary>
        EnabledForAzureAd,
        /// <summary>Recovery password rotation on for both Azure AD joined and hybrid joined devices</summary>
        EnabledForAzureAdAndHybrid,
    }
}
