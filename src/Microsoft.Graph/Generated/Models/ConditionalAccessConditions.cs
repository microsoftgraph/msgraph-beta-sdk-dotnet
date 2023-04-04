using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConditionalAccessConditions {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "users")]
        Users,
        [EnumMember(Value = "devicePlatform")]
        DevicePlatform,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "clientType")]
        ClientType,
        [EnumMember(Value = "signInRisk")]
        SignInRisk,
        [EnumMember(Value = "userRisk")]
        UserRisk,
        [EnumMember(Value = "time")]
        Time,
        [EnumMember(Value = "deviceState")]
        DeviceState,
        [EnumMember(Value = "client")]
        Client,
        [EnumMember(Value = "ipAddressSeenByAzureAD")]
        IpAddressSeenByAzureAD,
        [EnumMember(Value = "ipAddressSeenByResourceProvider")]
        IpAddressSeenByResourceProvider,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "servicePrincipals")]
        ServicePrincipals,
        [EnumMember(Value = "servicePrincipalRisk")]
        ServicePrincipalRisk,
    }
}
