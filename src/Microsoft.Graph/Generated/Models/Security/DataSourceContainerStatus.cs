using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DataSourceContainerStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "released")]
        Released,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
