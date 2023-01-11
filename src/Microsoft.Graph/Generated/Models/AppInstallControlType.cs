namespace Microsoft.Graph.Beta.Models {
    /// <summary>App Install control Setting</summary>
    public enum AppInstallControlType {
        /// <summary>Not configured</summary>
        NotConfigured,
        /// <summary>Turn off app recommendations</summary>
        Anywhere,
        /// <summary>Allow apps from Store only</summary>
        StoreOnly,
        /// <summary>Show me app recommendations</summary>
        Recommendations,
        /// <summary>Warn me before installing apps from outside the Store</summary>
        PreferStore,
    }
}
