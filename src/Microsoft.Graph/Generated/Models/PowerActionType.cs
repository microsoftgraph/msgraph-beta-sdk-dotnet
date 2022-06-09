namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum PowerActionType {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>No action</summary>
        NoAction,
        /// <summary>Put device in sleep state</summary>
        Sleep,
        /// <summary>Put device in hibernate state</summary>
        Hibernate,
        /// <summary>Shutdown device</summary>
        Shutdown,
    }
}
