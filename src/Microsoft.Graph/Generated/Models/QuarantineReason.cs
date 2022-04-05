namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
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
