using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkActivityTopicSource {
        [EnumMember(Value = "entityUrl")]
        EntityUrl,
        [EnumMember(Value = "text")]
        Text,
    }
}
