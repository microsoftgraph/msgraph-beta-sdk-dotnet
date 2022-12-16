namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ConditionalAccessConditions {
        None,
        Application,
        Users,
        DevicePlatform,
        Location,
        ClientType,
        SignInRisk,
        UserRisk,
        Time,
        DeviceState,
        Client,
        IpAddressSeenByAzureAD,
        IpAddressSeenByResourceProvider,
        UnknownFutureValue,
        ServicePrincipals,
        ServicePrincipalRisk,
    }
}
