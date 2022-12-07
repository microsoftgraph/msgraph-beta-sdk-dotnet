namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum LanManagerAuthenticationLevel {
        /// <summary>Send LM &amp; NTLM responses</summary>
        LmAndNltm,
        /// <summary>Send LM &amp; NTLM-use NTLMv2 session security if negotiated</summary>
        LmNtlmAndNtlmV2,
        /// <summary>Send LM &amp; NTLM responses only</summary>
        LmAndNtlmOnly,
        /// <summary>Send LM &amp; NTLMv2 responses only</summary>
        LmAndNtlmV2,
        /// <summary>Send LM &amp; NTLMv2 responses only. Refuse LM</summary>
        LmNtlmV2AndNotLm,
        /// <summary>Send LM &amp; NTLMv2 responses only. Refuse LM &amp; NTLM</summary>
        LmNtlmV2AndNotLmOrNtm,
    }
}
