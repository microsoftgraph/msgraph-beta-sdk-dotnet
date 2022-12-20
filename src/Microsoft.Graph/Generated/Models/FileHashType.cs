namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum FileHashType {
        Unknown,
        Sha1,
        Sha256,
        Md5,
        AuthenticodeHash256,
        LsHash,
        Ctph,
        UnknownFutureValue,
    }
}
