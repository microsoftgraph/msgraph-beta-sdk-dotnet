namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsMinimumSessionSecurity</summary>
    public enum LocalSecurityOptionsMinimumSessionSecurity {
        /// <summary>Send LM &amp; NTLM responses</summary>
        None,
        /// <summary>Send LM &amp; NTLM-use NTLMv2 session security if negotiated</summary>
        RequireNtmlV2SessionSecurity,
        /// <summary>Send LM &amp; NTLM responses only</summary>
        Require128BitEncryption,
        /// <summary>Send LM &amp; NTLMv2 responses only</summary>
        NtlmV2And128BitEncryption,
    }
}
