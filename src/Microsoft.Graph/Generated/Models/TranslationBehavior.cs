using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TranslationBehavior {
        [EnumMember(Value = "Ask")]
        Ask,
        [EnumMember(Value = "Yes")]
        Yes,
        [EnumMember(Value = "No")]
        No,
    }
}
