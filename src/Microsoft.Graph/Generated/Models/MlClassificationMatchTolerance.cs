using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MlClassificationMatchTolerance {
        [EnumMember(Value = "exact")]
        Exact,
        [EnumMember(Value = "near")]
        Near,
    }
}
