namespace Microsoft.Graph.Beta.Models {
    /// <summary>AppLogUploadStatus</summary>
    public enum AppLogUploadState {
        /// <summary>Default. Indicates that request is waiting to be processed or under processing.</summary>
        Pending,
        /// <summary>Indicates that request is completed with file uploaded to Azure blob for download.</summary>
        Completed,
        /// <summary>Indicates that request is completed with file uploaded to Azure blob for download.</summary>
        Failed,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
