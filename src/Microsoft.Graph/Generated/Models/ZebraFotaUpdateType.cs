namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ZebraFotaUpdateType {
        /// <summary>Custom update where the user selects specific BSP, OS version, and patch number to update to.</summary>
        Custom,
        /// <summary>The latest released update becomes the target OS. Latest may update the device to a new Android version.</summary>
        Latest,
        /// <summary>The device always looks for the latest package available in the repo and tries to update whenever a new package is available. This continues until the admin cancels the auto update.</summary>
        Auto,
        /// <summary>Unknown future enum value.</summary>
        UnknownFutureValue,
    }
}
