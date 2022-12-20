namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ActionAfterRetentionPeriod {
        None,
        Delete,
        StartDispositionReview,
        Relabel,
        UnknownFutureValue,
    }
}
