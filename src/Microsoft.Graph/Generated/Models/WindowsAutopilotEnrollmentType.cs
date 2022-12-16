namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
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
