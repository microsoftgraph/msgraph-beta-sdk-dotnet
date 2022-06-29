namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum CertificateIssuanceStates {
        Unknown,
        ChallengeIssued,
        ChallengeIssueFailed,
        RequestCreationFailed,
        RequestSubmitFailed,
        ChallengeValidationSucceeded,
        ChallengeValidationFailed,
        IssueFailed,
        IssuePending,
        Issued,
        ResponseProcessingFailed,
        ResponsePending,
        EnrollmentSucceeded,
        EnrollmentNotNeeded,
        Revoked,
        RemovedFromCollection,
        RenewVerified,
        InstallFailed,
        Installed,
        DeleteFailed,
        Deleted,
        RenewalRequested,
        Requested,
    }
}
