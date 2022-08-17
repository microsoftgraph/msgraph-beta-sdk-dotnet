namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ActionAfterRetentionPeriod {
        None,
        Delete,
        StartDispositionReview,
        Relabel,
        UnknownFutureValue,
    }
}
