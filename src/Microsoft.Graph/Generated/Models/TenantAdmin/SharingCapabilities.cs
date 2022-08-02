namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum SharingCapabilities {
        Disabled,
        ExternalUserSharingOnly,
        ExternalUserAndGuestSharing,
        ExistingExternalUserSharingOnly,
        UnknownFutureValue,
    }
}
