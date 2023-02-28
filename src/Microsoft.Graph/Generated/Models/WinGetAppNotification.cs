namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains value for notification status.</summary>
    public enum WinGetAppNotification {
        /// <summary>Show all notifications.</summary>
        ShowAll,
        /// <summary>Only show restart notification and suppress other notifications.</summary>
        ShowReboot,
        /// <summary>Hide all notifications.</summary>
        HideAll,
        /// <summary>Unknown future value, reserved for future usage as expandable enum.</summary>
        UnknownFutureValue,
    }
}
