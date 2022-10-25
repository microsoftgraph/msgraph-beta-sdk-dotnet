namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum RiskState {
        None,
        ConfirmedSafe,
        Remediated,
        Dismissed,
        AtRisk,
        ConfirmedCompromised,
        UnknownFutureValue,
    }
}
