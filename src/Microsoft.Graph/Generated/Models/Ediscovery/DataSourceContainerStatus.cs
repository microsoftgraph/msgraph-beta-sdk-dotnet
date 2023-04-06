using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum DataSourceContainerStatus {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Released")]
        Released,
        [EnumMember(Value = "UnknownFutureValue")]
        UnknownFutureValue,
    }
}
