namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public enum ActionState {
        None,
        Pending,
        Canceled,
        Active,
        Done,
        Failed,
        NotSupported,
    }
}
