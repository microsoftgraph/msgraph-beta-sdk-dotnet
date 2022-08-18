namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum GroupPolicyConfigurationIngestionType {
        /// <summary>Unknown policy configuration ingestion type</summary>
        Unknown,
        /// <summary>Indicates policy created have definitions ingested by IT admin with sufficient permissions through custom ingestion process</summary>
        Custom,
        /// <summary>Indicates policy created have definitions ingested through system ingestion process</summary>
        BuiltIn,
        /// <summary>Indicated atleast 1 tenant admin &amp; system ingested definitions configured for this policy</summary>
        Mixed,
        /// <summary>Unknown future enum value</summary>
        UnknownFutureValue,
    }
}
