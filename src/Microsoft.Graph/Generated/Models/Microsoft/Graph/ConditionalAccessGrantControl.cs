namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public enum ConditionalAccessGrantControl {
        Block,
        Mfa,
        CompliantDevice,
        DomainJoinedDevice,
        ApprovedApplication,
        CompliantApplication,
        PasswordChange,
        UnknownFutureValue,
    }
}
