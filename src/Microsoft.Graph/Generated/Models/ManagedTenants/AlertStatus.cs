namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum AlertStatus {
        Unknown,
        NewAlert,
        InProgress,
        Resolved,
        Dismissed,
        UnknownFutureValue,
    }
}
