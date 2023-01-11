namespace Microsoft.Graph.Beta.Models {
    /// <summary>Update behavior options for macOS software updates.</summary>
    public enum MacOSSoftwareUpdateBehavior {
        /// <summary>Not configured.</summary>
        NotConfigured,
        /// <summary>Download and/or install the software update, depending on the current device state.</summary>
        Default,
        /// <summary>Download the software update without installing it.</summary>
        DownloadOnly,
        /// <summary>Install an already downloaded software update.</summary>
        InstallASAP,
        /// <summary>Download the software update and notify the user via the App Store.</summary>
        NotifyOnly,
        /// <summary>Download the software update and install it at a later time.</summary>
        InstallLater,
    }
}
