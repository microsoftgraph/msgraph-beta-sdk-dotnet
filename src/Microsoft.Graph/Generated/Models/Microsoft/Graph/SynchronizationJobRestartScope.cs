namespace MicrosoftGraph.Models.Microsoft.Graph {
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
