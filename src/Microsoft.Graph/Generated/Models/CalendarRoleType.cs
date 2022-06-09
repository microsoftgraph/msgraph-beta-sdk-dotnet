namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public enum CalendarRoleType {
        None,
        FreeBusyRead,
        LimitedRead,
        Read,
        Write,
        DelegateWithoutPrivateEventAccess,
        DelegateWithPrivateEventAccess,
        Custom,
    }
}
