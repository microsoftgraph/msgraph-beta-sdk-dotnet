namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum RiskEventType {
        UnlikelyTravel,
        AnonymizedIPAddress,
        MaliciousIPAddress,
        UnfamiliarFeatures,
        MalwareInfectedIPAddress,
        SuspiciousIPAddress,
        LeakedCredentials,
        InvestigationsThreatIntelligence,
        Generic,
        AdminConfirmedUserCompromised,
        McasImpossibleTravel,
        McasSuspiciousInboxManipulationRules,
        InvestigationsThreatIntelligenceSigninLinked,
        MaliciousIPAddressValidCredentialsBlockedIP,
        UnknownFutureValue,
    }
}
