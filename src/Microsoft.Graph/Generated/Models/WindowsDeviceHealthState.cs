namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public enum WindowsDeviceHealthState {
        /// <summary>Computer is clean and no action is required</summary>
        Clean,
        /// <summary>Computer is in pending full scan state</summary>
        FullScanPending,
        /// <summary>Computer is in pending reboot state</summary>
        RebootPending,
        /// <summary>Computer is in pending manual steps state</summary>
        ManualStepsPending,
        /// <summary>Computer is in pending offline scan state</summary>
        OfflineScanPending,
        /// <summary>Computer is in critical failure state</summary>
        Critical,
    }
}
