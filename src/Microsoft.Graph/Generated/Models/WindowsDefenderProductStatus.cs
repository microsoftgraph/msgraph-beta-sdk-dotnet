namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum WindowsDefenderProductStatus {
        /// <summary>No status</summary>
        NoStatus,
        /// <summary>Service not running</summary>
        ServiceNotRunning,
        /// <summary>Service started without any malware protection engine</summary>
        ServiceStartedWithoutMalwareProtection,
        /// <summary>Pending full scan due to threat action</summary>
        PendingFullScanDueToThreatAction,
        /// <summary>Pending reboot due to threat action</summary>
        PendingRebootDueToThreatAction,
        /// <summary>Pending manual steps due to threat action </summary>
        PendingManualStepsDueToThreatAction,
        /// <summary>AV signatures out of date</summary>
        AvSignaturesOutOfDate,
        /// <summary>AS signatures out of date</summary>
        AsSignaturesOutOfDate,
        /// <summary>No quick scan has happened for a specified period</summary>
        NoQuickScanHappenedForSpecifiedPeriod,
        /// <summary>No full scan has happened for a specified period</summary>
        NoFullScanHappenedForSpecifiedPeriod,
        /// <summary>System initiated scan in progress</summary>
        SystemInitiatedScanInProgress,
        /// <summary>System initiated clean in progress</summary>
        SystemInitiatedCleanInProgress,
        /// <summary>There are samples pending submission</summary>
        SamplesPendingSubmission,
        /// <summary>Product running in evaluation mode</summary>
        ProductRunningInEvaluationMode,
        /// <summary>Product running in non-genuine Windows mode</summary>
        ProductRunningInNonGenuineMode,
        /// <summary>Product expired</summary>
        ProductExpired,
        /// <summary>Off-line scan required</summary>
        OfflineScanRequired,
        /// <summary>Service is shutting down as part of system shutdown</summary>
        ServiceShutdownAsPartOfSystemShutdown,
        /// <summary>Threat remediation failed critically</summary>
        ThreatRemediationFailedCritically,
        /// <summary>Threat remediation failed non-critically</summary>
        ThreatRemediationFailedNonCritically,
        /// <summary>No status flags set (well initialized state)</summary>
        NoStatusFlagsSet,
        /// <summary>Platform is out of date</summary>
        PlatformOutOfDate,
        /// <summary>Platform update is in progress</summary>
        PlatformUpdateInProgress,
        /// <summary>Platform is about to be outdated</summary>
        PlatformAboutToBeOutdated,
        /// <summary>Signature or platform end of life is past or is impending</summary>
        SignatureOrPlatformEndOfLifeIsPastOrIsImpending,
        /// <summary>Windows SMode signatures still in use on non-Win10S install</summary>
        WindowsSModeSignaturesInUseOnNonWin10SInstall,
    }
}
