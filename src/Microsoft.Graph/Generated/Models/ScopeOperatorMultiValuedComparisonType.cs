using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ScopeOperatorMultiValuedComparisonType {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Any")]
        Any,
    }
}
