namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of VPN security association encryption algorithm</summary>
    public enum VpnEncryptionAlgorithmType {
        /// <summary>AES-256</summary>
        Aes256,
        /// <summary>DES</summary>
        Des,
        /// <summary>3DES</summary>
        TripleDes,
        /// <summary>AES-128</summary>
        Aes128,
        /// <summary>AES-128-GCM</summary>
        Aes128Gcm,
        /// <summary>AES-256-GCM</summary>
        Aes256Gcm,
        /// <summary>AES-192</summary>
        Aes192,
        /// <summary>AES-192-GCM</summary>
        Aes192Gcm,
        /// <summary>ChaCha20Poly1305</summary>
        ChaCha20Poly1305,
    }
}
