namespace Microsoft.Graph.Beta.Models {
    /// <summary>An admin initiated action to be applied on a managed app.</summary>
    public enum ManagedAppRemediationAction {
        /// <summary>app and the corresponding company data to be blocked</summary>
        Block,
        /// <summary>app and the corresponding company data to be wiped</summary>
        Wipe,
        /// <summary>app and the corresponding user to be warned</summary>
        Warn,
    }
}
