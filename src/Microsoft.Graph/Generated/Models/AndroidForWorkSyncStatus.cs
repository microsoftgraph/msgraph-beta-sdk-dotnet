namespace Microsoft.Graph.Beta.Models {
    /// <summary>Sync status of the tenant with the Google EMM API</summary>
    public enum AndroidForWorkSyncStatus {
        Success,
        CredentialsNotValid,
        AndroidForWorkApiError,
        ManagementServiceError,
        UnknownError,
        None,
    }
}
