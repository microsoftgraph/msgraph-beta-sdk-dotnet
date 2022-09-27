namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum IosKioskModeAppType {
        /// <summary>Device default value, no intent.</summary>
        NotConfigured,
        /// <summary>The app to be run comes from the app store.</summary>
        AppStoreApp,
        /// <summary>The app to be run is built into the device.</summary>
        ManagedApp,
        /// <summary>The app to be run is a managed app.</summary>
        BuiltInApp,
    }
}
