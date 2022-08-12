namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public enum ProvisioningStepType {
        Import,
        Scoping,
        Matching,
        Processing,
        ReferenceResolution,
        Export,
        UnknownFutureValue,
    }
}
