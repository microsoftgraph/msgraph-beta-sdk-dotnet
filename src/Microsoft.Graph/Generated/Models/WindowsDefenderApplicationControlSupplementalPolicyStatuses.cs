namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum WindowsDefenderApplicationControlSupplementalPolicyStatuses {
        /// <summary>The status of the WindowsDefenderApplicationControl supplemental policy is not known.</summary>
        Unknown,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is in effect.</summary>
        Success,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is structurally okay but there is an error with authorizing the token.</summary>
        TokenError,
        /// <summary>The token does not authorize this WindowsDefenderApplicationControl supplemental policy.</summary>
        NotAuthorizedByToken,
        /// <summary>The WindowsDefenderApplicationControl supplemental policy is not found.</summary>
        PolicyNotFound,
    }
}
