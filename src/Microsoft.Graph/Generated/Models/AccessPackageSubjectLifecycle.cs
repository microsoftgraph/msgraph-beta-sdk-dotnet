using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccessPackageSubjectLifecycle {
        [EnumMember(Value = "notDefined")]
        NotDefined,
        [EnumMember(Value = "notGoverned")]
        NotGoverned,
        [EnumMember(Value = "governed")]
        Governed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
