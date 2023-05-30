using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationAttributeCollectionInputType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "radioSingleSelect")]
        RadioSingleSelect,
        [EnumMember(Value = "checkboxMultiSelect")]
        CheckboxMultiSelect,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
