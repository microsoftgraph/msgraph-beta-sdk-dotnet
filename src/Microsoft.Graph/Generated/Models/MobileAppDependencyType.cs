namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the dependency type associated with a relationship between two mobile apps.</summary>
    public enum MobileAppDependencyType {
        /// <summary>Indicates that the child app should be detected before installing the parent app.</summary>
        Detect,
        /// <summary>Indicates that the child app should be installed before installing the parent app.</summary>
        AutoInstall,
    }
}
