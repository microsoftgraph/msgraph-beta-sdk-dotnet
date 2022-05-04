namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ZebraFotaDeploymentState {
        PendingCreation,
        CreateFailed,
        Created,
        InProgress,
        Completed,
        PendingCancel,
        Canceled,
        UnknownFutureValue,
    }
}
