namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum ResultantAppStateDetail {
        /// <summary>Device architecture (e.g. x86/amd64) is not applicable for the application.</summary>
        ProcessorArchitectureNotApplicable,
        /// <summary>Available disk space on the target device is less than the configured minimum.</summary>
        MinimumDiskSpaceNotMet,
        /// <summary>OS version on the target device is less than the configured minimum.</summary>
        MinimumOsVersionNotMet,
        /// <summary>Amount of RAM on the target device is less than the configured minimum.</summary>
        MinimumPhysicalMemoryNotMet,
        /// <summary>Count of logical processors on the target device is less than the configured minimum.</summary>
        MinimumLogicalProcessorCountNotMet,
        /// <summary>CPU speed on the target device is less than the configured minimum.</summary>
        MinimumCpuSpeedNotMet,
        /// <summary>Application is not applicable to this platform. (e.g. Android app targeted to IOS)</summary>
        PlatformNotApplicable,
        /// <summary>File system requirement rule is not met</summary>
        FileSystemRequirementNotMet,
        /// <summary>Registry requirement rule is not met</summary>
        RegistryRequirementNotMet,
        /// <summary>PowerShell script requirement rule is not met</summary>
        PowerShellScriptRequirementNotMet,
        /// <summary>All targeted, superseding apps are not applicable.</summary>
        SupersedingAppsNotApplicable,
        /// <summary>No additional details are available.</summary>
        NoAdditionalDetails,
        /// <summary>One or more of the application&apos;s dependencies failed to install.</summary>
        DependencyFailedToInstall,
        /// <summary>One or more of the application&apos;s dependencies have requirements which are not met.</summary>
        DependencyWithRequirementsNotMet,
        /// <summary>One or more of the application&apos;s dependencies require a device reboot to complete installation.</summary>
        DependencyPendingReboot,
        /// <summary>One or more of the application&apos;s dependencies are configured to not automatically install.</summary>
        DependencyWithAutoInstallDisabled,
        /// <summary>A superseded app failed to uninstall.</summary>
        SupersededAppUninstallFailed,
        /// <summary>A superseded app requires a reboot to complete uninstall.</summary>
        SupersededAppUninstallPendingReboot,
        /// <summary>Superseded apps are being removed.</summary>
        RemovingSupersededApps,
        /// <summary>The latest version of the app failed to update from an earlier version.</summary>
        IosAppStoreUpdateFailedToInstall,
        /// <summary>An update is available.</summary>
        VppAppHasUpdateAvailable,
        /// <summary>The user rejected the app update.</summary>
        UserRejectedUpdate,
        /// <summary>To complete the removal of the app, the device must be rebooted.</summary>
        UninstallPendingReboot,
        /// <summary>Superseding applications are detected.</summary>
        SupersedingAppsDetected,
        /// <summary>Superseded applications are detected.</summary>
        SupersededAppsDetected,
        /// <summary>Application failed to install. See error code property for more details.</summary>
        SeeInstallErrorCode,
        /// <summary>Application is configured to not be automatically installed.</summary>
        AutoInstallDisabled,
        /// <summary>The app is managed but no longer installed.</summary>
        ManagedAppNoLongerPresent,
        /// <summary>The user rejected the app install.</summary>
        UserRejectedInstall,
        /// <summary>The user must log into the App Store to install app.</summary>
        UserIsNotLoggedIntoAppStore,
        /// <summary>App cannot be installed. An untargeted, superseding app was detected, which created a conflict.</summary>
        UntargetedSupersedingAppsDetected,
        /// <summary>App was removed in order to install a superseding app.</summary>
        AppRemovedBySupersedence,
        /// <summary>Application failed to uninstall. See error code property for more details.</summary>
        SeeUninstallErrorCode,
        /// <summary>Device must be rebooted to complete installation of the application.</summary>
        PendingReboot,
        /// <summary>One or more of the application&apos;s dependencies are installing.</summary>
        InstallingDependencies,
        /// <summary>Application content was downloaded to the device.</summary>
        ContentDownloaded,
    }
}
