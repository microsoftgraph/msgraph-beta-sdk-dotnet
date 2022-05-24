namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public enum CloudPcStatus {
        NotProvisioned,
        Provisioning,
        Provisioned,
        InGracePeriod,
        Deprovisioning,
        Failed,
        ProvisionedWithWarnings,
        Resizing,
        Restoring,
        PendingProvision,
        UnknownFutureValue,
    }
}
