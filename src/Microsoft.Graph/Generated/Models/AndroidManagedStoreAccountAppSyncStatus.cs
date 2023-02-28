namespace Microsoft.Graph.Beta.Models {
    /// <summary>Sync status of the tenant with the Google EMM API</summary>
    public enum AndroidManagedStoreAccountAppSyncStatus {
        Success,
        CredentialsNotValid,
        AndroidForWorkApiError,
        ManagementServiceError,
        UnknownError,
        None,
    }
}
