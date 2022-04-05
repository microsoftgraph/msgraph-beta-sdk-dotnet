namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum DeviceEnrollmentType {
        Unknown,
        UserEnrollment,
        DeviceEnrollmentManager,
        AppleBulkWithUser,
        AppleBulkWithoutUser,
        WindowsAzureADJoin,
        WindowsBulkUserless,
        WindowsAutoEnrollment,
        WindowsBulkAzureDomainJoin,
        WindowsCoManagement,
        WindowsAzureADJoinUsingDeviceAuth,
        AppleUserEnrollment,
        AppleUserEnrollmentWithServiceAccount,
        AzureAdJoinUsingAzureVmExtension,
        AndroidEnterpriseDedicatedDevice,
        AndroidEnterpriseFullyManaged,
        AndroidEnterpriseCorporateWorkProfile,
    }
}
