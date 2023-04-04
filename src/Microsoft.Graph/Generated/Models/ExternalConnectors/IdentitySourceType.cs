using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public enum IdentitySourceType {
        [EnumMember(Value = "azureActiveDirectory")]
        AzureActiveDirectory,
        [EnumMember(Value = "external")]
        External,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
