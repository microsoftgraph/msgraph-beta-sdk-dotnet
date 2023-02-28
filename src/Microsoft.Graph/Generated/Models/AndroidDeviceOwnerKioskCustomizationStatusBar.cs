namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing possible values for kiosk customization system navigation.</summary>
    public enum AndroidDeviceOwnerKioskCustomizationStatusBar {
        /// <summary>Not configured; this value defaults to STATUS_BAR_UNSPECIFIED.</summary>
        NotConfigured,
        /// <summary>System info and notifications are shown on the status bar in kiosk mode.</summary>
        NotificationsAndSystemInfoEnabled,
        /// <summary>Only system info is shown on the status bar in kiosk mode.</summary>
        SystemInfoOnly,
    }
}
