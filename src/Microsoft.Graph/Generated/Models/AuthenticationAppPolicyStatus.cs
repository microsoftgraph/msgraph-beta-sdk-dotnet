namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum AuthenticationAppPolicyStatus {
        Unknown,
        AppLockOutOfDate,
        AppLockEnabled,
        AppLockDisabled,
        AppContextOutOfDate,
        AppContextShown,
        AppContextNotShown,
        LocationContextOutOfDate,
        LocationContextShown,
        LocationContextNotShown,
        NumberMatchOutOfDate,
        NumberMatchCorrectNumberEntered,
        NumberMatchIncorrectNumberEntered,
        NumberMatchDeny,
        TamperResistantHardwareOutOfDate,
        TamperResistantHardwareUsed,
        TamperResistantHardwareNotUsed,
        UnknownFutureValue,
    }
}
