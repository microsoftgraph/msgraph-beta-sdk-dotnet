namespace MicrosoftGraph.Models.Microsoft.Graph {
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
