namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum SecurityBaselineComplianceState {
        Unknown,
        Secure,
        NotApplicable,
        NotSecure,
        Error,
        Conflict,
    }
}
