namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of certificate the VPN server will present to the VPN client for authentication</summary>
    public enum VpnServerCertificateType {
        /// <summary>RSA</summary>
        Rsa,
        /// <summary>ECDSA256</summary>
        Ecdsa256,
        /// <summary>ECDSA384</summary>
        Ecdsa384,
        /// <summary>ECDSA521</summary>
        Ecdsa521,
    }
}
