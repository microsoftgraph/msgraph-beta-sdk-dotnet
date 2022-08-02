namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum IosUpdatesInstallStatus {
        UpdateScanFailed,
        DeviceOsHigherThanDesiredOsVersion,
        UpdateError,
        SharedDeviceUserLoggedInError,
        NotSupportedOperation,
        InstallFailed,
        InstallPhoneCallInProgress,
        InstallInsufficientPower,
        InstallInsufficientSpace,
        Installing,
        DownloadInsufficientNetwork,
        DownloadInsufficientPower,
        DownloadInsufficientSpace,
        DownloadRequiresComputer,
        DownloadFailed,
        Downloading,
        Timeout,
        MdmClientCrashed,
        Success,
        Available,
        Idle,
        Unknown,
    }
}
