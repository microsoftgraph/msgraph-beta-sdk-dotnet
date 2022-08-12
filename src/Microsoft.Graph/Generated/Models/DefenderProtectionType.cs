namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DefenderProtectionType {
        /// <summary>Device default value, no intent.</summary>
        UserDefined,
        /// <summary>Block functionality.</summary>
        Enable,
        /// <summary>Allow functionality but generate logs.</summary>
        AuditMode,
        /// <summary>Warning message to end user with ability to bypass block from attack surface reduction rule.</summary>
        Warn,
        /// <summary>Not configured.</summary>
        NotConfigured,
    }
}
