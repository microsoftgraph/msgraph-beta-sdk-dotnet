namespace MicrosoftGraph.Models.Microsoft.Graph {
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
