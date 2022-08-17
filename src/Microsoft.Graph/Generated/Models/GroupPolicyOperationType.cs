namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum GroupPolicyOperationType {
        /// <summary>Group Policy invalid operation type.</summary>
        None,
        /// <summary>Group Policy upload operation type.</summary>
        Upload,
        /// <summary>Group Policy upload new version operation type.</summary>
        UploadNewVersion,
        /// <summary>Group Policy add new language(ADML) files operation type.</summary>
        AddLanguageFiles,
        /// <summary>Group Policy remove language(ADML) files operation type.</summary>
        RemoveLanguageFiles,
        /// <summary>Group Policy update language(ADML) files operation type.</summary>
        UpdateLanguageFiles,
        /// <summary>Group Policy remove uploaded file operation type.</summary>
        Remove,
    }
}
