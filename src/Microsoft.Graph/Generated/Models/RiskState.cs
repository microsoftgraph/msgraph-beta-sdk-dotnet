namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
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
