using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AttributeMappingSourceType {
        [EnumMember(Value = "Attribute")]
        Attribute,
        [EnumMember(Value = "Constant")]
        Constant,
        [EnumMember(Value = "Function")]
        Function,
    }
}
