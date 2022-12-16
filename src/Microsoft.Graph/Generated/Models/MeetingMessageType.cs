namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum MeetingMessageType {
        None,
        MeetingRequest,
        MeetingCancelled,
        MeetingAccepted,
        MeetingTentativelyAccepted,
        MeetingDeclined,
    }
}
