namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum NonEapAuthenticationMethodForEapTtlsType {
        /// <summary>Unencrypted password (PAP).</summary>
        UnencryptedPassword,
        /// <summary>Challenge Handshake Authentication Protocol (CHAP).</summary>
        ChallengeHandshakeAuthenticationProtocol,
        /// <summary> Microsoft CHAP (MS-CHAP).</summary>
        MicrosoftChap,
        /// <summary>Microsoft CHAP Version 2 (MS-CHAP v2).</summary>
        MicrosoftChapVersionTwo,
    }
}
