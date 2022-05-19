namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum SimulationStatus {
        Unknown,
        Draft,
        Running,
        Scheduled,
        Succeeded,
        Failed,
        Cancelled,
        Excluded,
        UnknownFutureValue,
    }
}
