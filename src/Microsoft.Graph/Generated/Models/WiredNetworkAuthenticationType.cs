namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WiredNetworkAuthenticationType {
        /// <summary>None</summary>
        None,
        /// <summary>User Authentication</summary>
        User,
        /// <summary>Machine Authentication</summary>
        Machine,
        /// <summary>Machine or User Authentication</summary>
        MachineOrUser,
        /// <summary>Guest Authentication</summary>
        Guest,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
    }
}
