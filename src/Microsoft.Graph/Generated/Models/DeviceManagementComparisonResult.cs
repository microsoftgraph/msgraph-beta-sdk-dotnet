namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the compare method.</summary>
    public enum DeviceManagementComparisonResult {
        /// <summary>Unknown setting comparison</summary>
        Unknown,
        /// <summary>The setting values are equal</summary>
        Equal,
        /// <summary>The setting values are not equal</summary>
        NotEqual,
        /// <summary>The setting is added</summary>
        Added,
        /// <summary>The setting is removed</summary>
        Removed,
    }
}
