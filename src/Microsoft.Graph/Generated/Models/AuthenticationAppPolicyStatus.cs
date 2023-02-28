namespace Microsoft.Graph.Beta.Models {
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
