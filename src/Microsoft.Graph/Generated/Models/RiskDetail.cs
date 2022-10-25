namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum RiskDetail {
        None,
        AdminGeneratedTemporaryPassword,
        UserPerformedSecuredPasswordChange,
        UserPerformedSecuredPasswordReset,
        AdminConfirmedSigninSafe,
        AiConfirmedSigninSafe,
        UserPassedMFADrivenByRiskBasedPolicy,
        AdminDismissedAllRiskForUser,
        AdminConfirmedSigninCompromised,
        Hidden,
        AdminConfirmedUserCompromised,
        UnknownFutureValue,
        AdminConfirmedServicePrincipalCompromised,
        AdminDismissedAllRiskForServicePrincipal,
        M365DAdminDismissedDetection,
    }
}
