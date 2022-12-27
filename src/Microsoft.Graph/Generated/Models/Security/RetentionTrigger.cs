namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum RetentionTrigger {
        DateLabeled,
        DateCreated,
        DateModified,
        DateOfEvent,
        UnknownFutureValue,
    }
}
