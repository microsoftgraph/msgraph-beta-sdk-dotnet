namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
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
