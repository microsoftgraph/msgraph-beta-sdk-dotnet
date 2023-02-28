namespace Microsoft.Graph.Beta.Models {
    /// <summary>Category Ingestion source</summary>
    public enum IngestionSource {
        /// <summary>Indicates unknown category</summary>
        Unknown,
        /// <summary>Indicates the category is ingested by IT admin with sufficient permissions through custom ingestion process</summary>
        Custom,
        /// <summary>Indicates the category is ingested through system ingestion process</summary>
        BuiltIn,
        /// <summary>Unknown future enum value</summary>
        UnknownFutureValue,
    }
}
