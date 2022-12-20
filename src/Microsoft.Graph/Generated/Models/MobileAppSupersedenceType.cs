namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum MobileAppSupersedenceType {
        /// <summary>Indicates that the child app should be updated by the internal logic of the parent app.</summary>
        Update,
        /// <summary>Indicates that the child app should be uninstalled before installing the parent app.</summary>
        Replace,
    }
}
