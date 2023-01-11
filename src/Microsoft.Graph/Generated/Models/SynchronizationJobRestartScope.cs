namespace Microsoft.Graph.Beta.Models {
    public enum SynchronizationJobRestartScope {
        None,
        ConnectorDataStore,
        Escrows,
        Watermark,
        QuarantineState,
        Full,
        ForceDeletes,
    }
}
