namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum GroupPolicyUploadedDefinitionFileStatus {
        /// <summary>Group Policy uploaded definition file invalid upload status.</summary>
        None,
        /// <summary>Group Policy uploaded definition file upload in progress.</summary>
        UploadInProgress,
        /// <summary>Group Policy uploaded definition file available.</summary>
        Available,
        /// <summary>Group Policy uploaded definition file assigned to policy.</summary>
        Assigned,
        /// <summary>Group Policy uploaded definition file removal in progress.</summary>
        RemovalInProgress,
        /// <summary>Group Policy uploaded definition file upload failed.</summary>
        UploadFailed,
        /// <summary>Group Policy uploaded definition file removal failed.</summary>
        RemovalFailed,
    }
}
