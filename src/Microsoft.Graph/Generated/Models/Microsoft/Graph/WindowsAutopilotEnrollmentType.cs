namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsAutopilotEnrollmentType {
        Unknown,
        AzureADJoinedWithAutopilotProfile,
        OfflineDomainJoined,
        AzureADJoinedUsingDeviceAuthWithAutopilotProfile,
        AzureADJoinedUsingDeviceAuthWithoutAutopilotProfile,
        AzureADJoinedWithOfflineAutopilotProfile,
        AzureADJoinedWithWhiteGlove,
        OfflineDomainJoinedWithWhiteGlove,
        OfflineDomainJoinedWithOfflineAutopilotProfile,
    }
}
