namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AndroidManagedStoreAutoUpdateMode {
        /// <summary>Default update behavior (device must be connected to Wifi, charging and not actively used).</summary>
        Default,
        /// <summary>Updates are postponed for a maximum of 90 days after the app becomes out of date.</summary>
        Postponed,
        /// <summary>The app is updated as soon as possible by the developer. If device is online, it will be updated within minutes.</summary>
        Priority,
        /// <summary>Unknown future mode (reserved, not used right now).</summary>
        UnknownFutureValue,
    }
}
