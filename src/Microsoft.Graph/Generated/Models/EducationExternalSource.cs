using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationExternalSource {
        [EnumMember(Value = "sis")]
        Sis,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "lms")]
        Lms,
    }
}
