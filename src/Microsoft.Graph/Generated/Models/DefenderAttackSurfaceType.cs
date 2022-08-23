namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum DefenderAttackSurfaceType {
        /// <summary>Default, which disables attack surface reduction rule.</summary>
        UserDefined,
        /// <summary>Enable the attack surface reduction rule.</summary>
        Block,
        /// <summary>Evaluate how the ASR rule would impact your organization if enabled. Does not change functionality but generate logs.</summary>
        AuditMode,
        /// <summary>Warning message to end user with ability to bypass block from attack surface reduction rule.</summary>
        Warn,
        /// <summary>Disable the attack surface reduction rule</summary>
        Disable,
    }
}
