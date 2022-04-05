namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum RunState {
        Unknown,
        Success,
        Fail,
        ScriptError,
        Pending,
        NotApplicable,
    }
}
