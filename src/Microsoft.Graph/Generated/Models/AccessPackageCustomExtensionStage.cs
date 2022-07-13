namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AccessPackageCustomExtensionStage {
        AssignmentRequestCreated,
        AssignmentRequestApproved,
        AssignmentRequestGranted,
        AssignmentRequestRemoved,
        AssignmentFourteenDaysBeforeExpiration,
        AssignmentOneDayBeforeExpiration,
        UnknownFutureValue,
    }
}
