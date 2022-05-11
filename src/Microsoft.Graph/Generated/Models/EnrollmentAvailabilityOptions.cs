namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum EnrollmentAvailabilityOptions {
        /// <summary>Device enrollment flow is shown to the end user with guided enrollment prompts</summary>
        AvailableWithPrompts,
        /// <summary>Device enrollment flow is available to the end user without guided enrollment prompts</summary>
        AvailableWithoutPrompts,
        /// <summary>Device enrollment flow is unavailable to the enduser</summary>
        Unavailable,
    }
}
