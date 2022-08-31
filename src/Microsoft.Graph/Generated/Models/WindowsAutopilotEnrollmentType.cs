namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
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
