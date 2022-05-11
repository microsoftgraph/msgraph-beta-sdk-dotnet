namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum UserPfxPaddingScheme {
        /// <summary>Unknown padding Scheme.</summary>
        None,
        /// <summary>Pkcs1 is no longer supported</summary>
        Pkcs1,
        /// <summary>OaepSha1 is no longer supported</summary>
        OaepSha1,
        /// <summary>Use OAEP SHA-256 padding.</summary>
        OaepSha256,
        /// <summary>Use OAEP SHA-384 padding.</summary>
        OaepSha384,
        /// <summary>Use OAEP SHA-512 padding.</summary>
        OaepSha512,
    }
}
