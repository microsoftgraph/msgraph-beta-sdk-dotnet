namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of execution status of the device management script.</summary>
    public enum RunState {
        /// <summary>Unknown result.</summary>
        Unknown,
        /// <summary>Script is run successfully.</summary>
        Success,
        /// <summary>Script failed to run.</summary>
        Fail,
        /// <summary>Discovery script hits error.</summary>
        ScriptError,
        /// <summary>Script is pending to execute.</summary>
        Pending,
        /// <summary>Script is not applicable for this device.</summary>
        NotApplicable,
    }
}
