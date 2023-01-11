namespace Microsoft.Graph.Beta.Models {
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
