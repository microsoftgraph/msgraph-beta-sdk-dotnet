namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DriverCategory {
        /// <summary>This indicates a driver is recommended by Microsoft.</summary>
        Recommended,
        /// <summary>This indicates a driver was recommended by Microsoft and IT admin has taken some approval action on it.</summary>
        PreviouslyApproved,
        /// <summary>This indicates a driver is never recommended by Microsoft.</summary>
        Other,
    }
}
