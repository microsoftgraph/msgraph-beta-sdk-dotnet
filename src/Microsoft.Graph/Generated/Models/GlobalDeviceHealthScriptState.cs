namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the areGlobalScriptsAvailable method.</summary>
    public enum GlobalDeviceHealthScriptState {
        /// <summary>Global device health scripts are not configured</summary>
        NotConfigured,
        /// <summary>Global device health scripts are configured but not fully enabled</summary>
        Pending,
        /// <summary>Global device health scripts are enabled and ready to use</summary>
        Enabled,
    }
}
