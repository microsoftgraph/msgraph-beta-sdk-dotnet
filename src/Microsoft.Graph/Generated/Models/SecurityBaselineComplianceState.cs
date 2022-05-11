namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum SecurityBaselineComplianceState {
        /// <summary>Unknown state</summary>
        Unknown,
        /// <summary>Secure state</summary>
        Secure,
        /// <summary>Not applicable state</summary>
        NotApplicable,
        /// <summary>Not secure state</summary>
        NotSecure,
        /// <summary>Error state</summary>
        Error,
        /// <summary>Conflict state</summary>
        Conflict,
    }
}
