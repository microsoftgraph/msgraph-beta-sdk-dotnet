namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ServiceSource {
        Unknown,
        MicrosoftDefenderForEndpoint,
        MicrosoftDefenderForIdentity,
        MicrosoftDefenderForCloudApps,
        MicrosoftDefenderForOffice365,
        Microsoft365Defender,
        AzureAdIdentityProtection,
        MicrosoftAppGovernance,
        DataLossPrevention,
        UnknownFutureValue,
    }
}
