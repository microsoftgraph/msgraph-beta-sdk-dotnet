using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ThreatAssessmentResultType {
        [EnumMember(Value = "checkPolicy")]
        CheckPolicy,
        [EnumMember(Value = "rescan")]
        Rescan,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
