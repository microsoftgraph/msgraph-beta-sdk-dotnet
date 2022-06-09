namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the instantiate method.</summary>
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
