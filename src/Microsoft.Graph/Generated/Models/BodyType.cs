using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum BodyType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
    }
}
