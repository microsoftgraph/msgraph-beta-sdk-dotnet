namespace MicrosoftGraph.Models.Microsoft.Graph {
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
