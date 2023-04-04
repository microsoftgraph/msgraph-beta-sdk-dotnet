using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Sync status of the tenant with the Google EMM API</summary>
    public enum AndroidManagedStoreAccountAppSyncStatus {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "credentialsNotValid")]
        CredentialsNotValid,
        [EnumMember(Value = "androidForWorkApiError")]
        AndroidForWorkApiError,
        [EnumMember(Value = "managementServiceError")]
        ManagementServiceError,
        [EnumMember(Value = "unknownError")]
        UnknownError,
        [EnumMember(Value = "none")]
        None,
    }
}
