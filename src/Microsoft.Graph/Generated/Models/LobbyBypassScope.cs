namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum LobbyBypassScope {
        Organizer,
        Organization,
        OrganizationAndFederated,
        Everyone,
        UnknownFutureValue,
        Invited,
        OrganizationExcludingGuests,
    }
}
