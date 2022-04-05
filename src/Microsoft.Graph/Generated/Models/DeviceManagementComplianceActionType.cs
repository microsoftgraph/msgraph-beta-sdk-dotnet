namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DeviceManagementComplianceActionType {
        NoAction,
        Notification,
        Block,
        Retire,
        Wipe,
        RemoveResourceAccessProfiles,
        PushNotification,
        RemoteLock,
    }
}
