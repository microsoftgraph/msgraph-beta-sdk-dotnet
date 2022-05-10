namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum ZebraFotaDeploymentState {
        /// <summary>Deployment is created but Zebra has not confirmed its creation.</summary>
        PendingCreation,
        /// <summary>Deployment was not successfully created with Zebra.</summary>
        CreateFailed,
        /// <summary>Deployment has been created but has not been deployed yet.</summary>
        Created,
        /// <summary>Deployment has started but not completed.</summary>
        InProgress,
        /// <summary>Deployment has completed or end date has passed.</summary>
        Completed,
        /// <summary>Admin has requested to cancel a deployment but Zebra has not confirmed cancellation.</summary>
        PendingCancel,
        /// <summary>Deployment has been successfully canceled by Zebra.</summary>
        Canceled,
        /// <summary>Unknown future enum value.</summary>
        UnknownFutureValue,
    }
}
