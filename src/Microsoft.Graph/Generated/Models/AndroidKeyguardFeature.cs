namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AndroidKeyguardFeature {
        /// <summary>Not configured; this value is ignored.</summary>
        NotConfigured,
        /// <summary>Camera usage when on secure keyguard screens.</summary>
        Camera,
        /// <summary>Showing notifications when on secure keyguard screens.</summary>
        Notifications,
        /// <summary>Showing unredacted notifications when on secure keyguard screens.</summary>
        UnredactedNotifications,
        /// <summary>Trust agent state when on secure keyguard screens.</summary>
        TrustAgents,
        /// <summary>Fingerprint sensor usage when on secure keyguard screens.</summary>
        Fingerprint,
        /// <summary>Notification text entry when on secure keyguard screens.</summary>
        RemoteInput,
        /// <summary>All keyguard features when on secure keyguard screens.</summary>
        AllFeatures,
        /// <summary>Face authentication on secure keyguard screens.</summary>
        Face,
        /// <summary>Iris authentication on secure keyguard screens.</summary>
        Iris,
        /// <summary>All biometric authentication on secure keyguard screens.</summary>
        Biometrics,
    }
}
