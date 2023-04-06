using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SensitiveTypeScope {
        [EnumMember(Value = "fullDocument")]
        FullDocument,
        [EnumMember(Value = "partialDocument")]
        PartialDocument,
    }
}
