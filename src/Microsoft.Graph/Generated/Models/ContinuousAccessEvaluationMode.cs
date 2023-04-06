using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ContinuousAccessEvaluationMode {
        [EnumMember(Value = "strictEnforcement")]
        StrictEnforcement,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
