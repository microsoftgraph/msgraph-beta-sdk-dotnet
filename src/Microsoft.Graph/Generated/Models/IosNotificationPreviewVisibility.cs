namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum IosNotificationPreviewVisibility {
        /// <summary>Notification preview settings will not be overwritten.</summary>
        NotConfigured,
        /// <summary>Always show notification previews.</summary>
        AlwaysShow,
        /// <summary>Only show notification previews when the device is unlocked.</summary>
        HideWhenLocked,
        /// <summary>Never show notification previews.</summary>
        NeverShow,
    }
}
