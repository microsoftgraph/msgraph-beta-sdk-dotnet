namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum Win32LobAppFileSystemDetectionType {
        /// <summary>Not configured.</summary>
        NotConfigured,
        /// <summary>Whether the specified file or folder exists.</summary>
        Exists,
        /// <summary>Last modified date.</summary>
        ModifiedDate,
        /// <summary>Created date.</summary>
        CreatedDate,
        /// <summary>Version value type.</summary>
        Version,
        /// <summary>Size detection type.</summary>
        SizeInMB,
        /// <summary>The specified file or folder does not exist.</summary>
        DoesNotExist,
    }
}
