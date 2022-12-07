namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum EdgeKioskModeRestrictionType {
        /// <summary>Not configured (unrestricted).</summary>
        NotConfigured,
        /// <summary>Interactive/Digital signage in single-app mode.</summary>
        DigitalSignage,
        /// <summary>Normal mode (full version of Microsoft Edge).</summary>
        NormalMode,
        /// <summary>Public browsing in single-app mode.</summary>
        PublicBrowsingSingleApp,
        /// <summary>Public browsing (inPrivate) in multi-app mode.</summary>
        PublicBrowsingMultiApp,
    }
}
