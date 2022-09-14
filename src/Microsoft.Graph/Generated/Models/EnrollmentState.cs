namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum EnrollmentState {
        /// <summary>Device enrollment state is unknown</summary>
        Unknown,
        /// <summary>Device is Enrolled.</summary>
        Enrolled,
        /// <summary>Enrolled but it&apos;s enrolled via enrollment profile and the enrolled profile is different from the assigned profile.</summary>
        PendingReset,
        /// <summary>Not enrolled and there is enrollment failure record.</summary>
        Failed,
        /// <summary>Device is imported but not enrolled.</summary>
        NotContacted,
        /// <summary>Device is enrolled as userless, but is blocked from moving to user enrollment because the app failed to install.</summary>
        Blocked,
    }
}
