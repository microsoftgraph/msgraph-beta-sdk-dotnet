namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum MacOSSoftwareUpdateState {
        /// <summary>The software update successfully installed</summary>
        Success,
        /// <summary>The software update is being downloaded</summary>
        Downloading,
        /// <summary>The software update has been downloaded</summary>
        Downloaded,
        /// <summary>The software update is being installed</summary>
        Installing,
        /// <summary>No action is being taken on this software update</summary>
        Idle,
        /// <summary>The software update is available on the device</summary>
        Available,
        /// <summary>The software update has been scheduled on the device</summary>
        Scheduled,
        /// <summary>The software update download has failed</summary>
        DownloadFailed,
        /// <summary>There is not enough space to download the update</summary>
        DownloadInsufficientSpace,
        /// <summary>There is not enough power to download the update</summary>
        DownloadInsufficientPower,
        /// <summary>There is insufficient network capacity to download the update</summary>
        DownloadInsufficientNetwork,
        /// <summary>There is not enough space to install the update</summary>
        InstallInsufficientSpace,
        /// <summary>There is not enough power to install the update</summary>
        InstallInsufficientPower,
        /// <summary>Installation has failed for an unspecified reason</summary>
        InstallFailed,
        /// <summary>The schedule update command has failed for an unspecified reason</summary>
        CommandFailed,
    }
}
