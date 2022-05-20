namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
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
