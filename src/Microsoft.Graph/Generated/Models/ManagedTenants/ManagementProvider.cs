using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum ManagementProvider {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "community")]
        Community,
        [EnumMember(Value = "indirectProvider")]
        IndirectProvider,
        [EnumMember(Value = "self")]
        Self,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
