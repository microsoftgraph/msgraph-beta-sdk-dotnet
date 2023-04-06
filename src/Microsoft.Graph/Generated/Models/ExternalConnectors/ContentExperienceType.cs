using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public enum ContentExperienceType {
        [EnumMember(Value = "search")]
        Search,
        [EnumMember(Value = "compliance")]
        Compliance,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
