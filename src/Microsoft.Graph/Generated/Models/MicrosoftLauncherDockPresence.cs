namespace Microsoft.Graph.Beta.Models {
    /// <summary>Microsoft Launcher Dock Presence selection.</summary>
    public enum MicrosoftLauncherDockPresence {
        /// <summary>Not configured; this value is ignored.</summary>
        NotConfigured,
        /// <summary>Indicates the device&apos;s dock will be displayed on the device.</summary>
        Show,
        /// <summary>Indicates the device&apos;s dock will be hidden on the device, but the user can access the dock by dragging the handler on the bottom of the screen.</summary>
        Hide,
        /// <summary>Indicates the device&apos;s dock will be disabled on the device.</summary>
        Disabled,
    }
}
