namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum MobileAppContentFileUploadState {
        Success,
        TransientError,
        Error,
        Unknown,
        AzureStorageUriRequestSuccess,
        AzureStorageUriRequestPending,
        AzureStorageUriRequestFailed,
        AzureStorageUriRequestTimedOut,
        AzureStorageUriRenewalSuccess,
        AzureStorageUriRenewalPending,
        AzureStorageUriRenewalFailed,
        AzureStorageUriRenewalTimedOut,
        CommitFileSuccess,
        CommitFilePending,
        CommitFileFailed,
        CommitFileTimedOut,
    }
}
