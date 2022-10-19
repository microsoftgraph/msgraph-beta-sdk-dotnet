namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DefenderPotentiallyUnwantedAppAction {
        /// <summary>PUA Protection is off. Defender will not protect against potentially unwanted applications.</summary>
        DeviceDefault,
        /// <summary>PUA Protection is on. Detected items are blocked. They will show in history along with other threats.</summary>
        Block,
        /// <summary>Audit mode. Defender will detect potentially unwanted applications, but take no actions. You can review information about applications Defender would have taken action against by searching for events created by Defender in the Event Viewer.</summary>
        Audit,
    }
}
