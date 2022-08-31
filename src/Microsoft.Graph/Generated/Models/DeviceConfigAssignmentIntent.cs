namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceConfigAssignmentIntent {
        /// <summary>Ensure that the configuration profile is applied to the devices in the assignment.</summary>
        Apply,
        /// <summary>Ensure that the configuration profile is removed from devices that have previously installed the configuration profile.</summary>
        Remove,
    }
}
