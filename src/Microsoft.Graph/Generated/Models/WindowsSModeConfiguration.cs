namespace Microsoft.Graph.Beta.Models {
    /// <summary>The possible options to configure S mode unlock</summary>
    public enum WindowsSModeConfiguration {
        /// <summary>This option will remove all restrictions to unlock S mode - default</summary>
        NoRestriction,
        /// <summary>This option will block the user to unlock the device from S mode</summary>
        Block,
        /// <summary>This option will unlock the device from S mode</summary>
        Unlock,
    }
}
