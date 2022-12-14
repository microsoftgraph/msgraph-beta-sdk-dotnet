namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
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
