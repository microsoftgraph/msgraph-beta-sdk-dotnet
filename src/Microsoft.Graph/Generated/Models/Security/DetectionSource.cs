namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DetectionSource {
        Unknown,
        MicrosoftDefenderForEndpoint,
        Antivirus,
        SmartScreen,
        CustomTi,
        MicrosoftDefenderForOffice365,
        AutomatedInvestigation,
        MicrosoftThreatExperts,
        CustomDetection,
        MicrosoftDefenderForIdentity,
        CloudAppSecurity,
        Microsoft365Defender,
        AzureAdIdentityProtection,
        Manual,
        MicrosoftDataLossPrevention,
        AppGovernancePolicy,
        AppGovernanceDetection,
        UnknownFutureValue,
    }
}
