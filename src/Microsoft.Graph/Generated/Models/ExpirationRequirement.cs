namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
