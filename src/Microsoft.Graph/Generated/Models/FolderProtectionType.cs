namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum FolderProtectionType {
        /// <summary>Device default value, no intent.</summary>
        UserDefined,
        /// <summary>Block functionality.</summary>
        Enable,
        /// <summary>Allow functionality but generate logs.</summary>
        AuditMode,
        /// <summary>Block untrusted apps from writing to disk sectors.</summary>
        BlockDiskModification,
        /// <summary>Generate logs when untrusted apps write to disk sectors.</summary>
        AuditDiskModification,
    }
}
