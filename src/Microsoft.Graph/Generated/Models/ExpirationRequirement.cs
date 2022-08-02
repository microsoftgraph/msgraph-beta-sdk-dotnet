namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum ExpirationRequirement {
        RememberMultifactorAuthenticationOnTrustedDevices,
        TenantTokenLifetimePolicy,
        AudienceTokenLifetimePolicy,
        SignInFrequencyPeriodicReauthentication,
        NgcMfa,
        SignInFrequencyEveryTime,
        UnknownFutureValue,
    }
}
