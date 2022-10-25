namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ManagedAppFlaggedReason {
        /// <summary>No issue.</summary>
        None,
        /// <summary>The app registration is running on a rooted/unlocked device.</summary>
        RootedDevice,
        /// <summary>The app registration is running on an Android device on which the bootloader is unlocked.</summary>
        AndroidBootloaderUnlocked,
        /// <summary>The app registration is running on an Android device on which the factory ROM has been modified.</summary>
        AndroidFactoryRomModified,
    }
}
