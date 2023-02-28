namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines when notification previews are visible on an iOS device. Previews can include things like text (from Messages and Mail) and invitation details (from Calendar). When configured, it will override the user&apos;s defined preview settings.</summary>
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
