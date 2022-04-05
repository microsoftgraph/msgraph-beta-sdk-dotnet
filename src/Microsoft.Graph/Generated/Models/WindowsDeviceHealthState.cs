namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum WindowsDeviceHealthState {
        Clean,
        FullScanPending,
        RebootPending,
        ManualStepsPending,
        OfflineScanPending,
        Critical,
    }
}
