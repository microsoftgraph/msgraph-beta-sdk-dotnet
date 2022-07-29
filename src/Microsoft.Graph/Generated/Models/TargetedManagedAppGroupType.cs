namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum TargetedManagedAppGroupType {
        /// <summary>Target the collection of apps manually selected by the admin.</summary>
        SelectedPublicApps,
        /// <summary>Target the core set of Microsoft apps (Office, Edge, etc).</summary>
        AllCoreMicrosoftApps,
        /// <summary>Target all apps with Microsoft as publisher.</summary>
        AllMicrosoftApps,
        /// <summary>Target all apps with an available assignment.</summary>
        AllApps,
    }
}
