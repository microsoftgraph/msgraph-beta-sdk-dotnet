using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DirectoryDefinitionDiscoverabilities {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "AttributeNames")]
        AttributeNames,
        [EnumMember(Value = "AttributeDataTypes")]
        AttributeDataTypes,
        [EnumMember(Value = "AttributeReadOnly")]
        AttributeReadOnly,
        [EnumMember(Value = "ReferenceAttributes")]
        ReferenceAttributes,
        [EnumMember(Value = "UnknownFutureValue")]
        UnknownFutureValue,
    }
}
