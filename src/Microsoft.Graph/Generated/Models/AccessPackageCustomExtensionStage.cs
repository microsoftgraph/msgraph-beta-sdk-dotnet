namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
