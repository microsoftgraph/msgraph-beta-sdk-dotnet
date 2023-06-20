using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ApplicationKeyUsage {
        [EnumMember(Value = "sign")]
        Sign,
        [EnumMember(Value = "verify")]
        Verify,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
