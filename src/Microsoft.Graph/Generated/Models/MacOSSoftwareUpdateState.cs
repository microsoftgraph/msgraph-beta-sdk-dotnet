namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum MacOSSoftwareUpdateState {
        Success,
        Downloading,
        Downloaded,
        Installing,
        Idle,
        Available,
        Scheduled,
        DownloadFailed,
        DownloadInsufficientSpace,
        DownloadInsufficientPower,
        DownloadInsufficientNetwork,
        InstallInsufficientSpace,
        InstallInsufficientPower,
        InstallFailed,
        CommandFailed,
    }
}
