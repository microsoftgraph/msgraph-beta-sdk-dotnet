namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum QuarantineReason {
        EncounteredBaseEscrowThreshold,
        EncounteredTotalEscrowThreshold,
        EncounteredEscrowProportionThreshold,
        EncounteredQuarantineException,
        Unknown,
        QuarantinedOnDemand,
        TooManyDeletes,
        IngestionInterrupted,
    }
}
