using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum AdditionalDataOptions {
        [EnumMember(Value = "allVersions")]
        AllVersions,
        [EnumMember(Value = "linkedFiles")]
        LinkedFiles,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
