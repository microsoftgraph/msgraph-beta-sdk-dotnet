namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum RuleMode {
        Audit,
        AuditAndNotify,
        Enforce,
        PendingDeletion,
        Test,
    }
}
