namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum DataSourceHoldStatus {
        NotApplied,
        Applied,
        Applying,
        Removing,
        Partial,
        UnknownFutureValue,
    }
}
