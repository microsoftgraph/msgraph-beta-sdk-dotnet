namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the autopilotEvents property of the microsoft.graph.deviceManagement entity.</summary>
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
