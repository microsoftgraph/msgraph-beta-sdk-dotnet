using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcProvisioningType {
        [EnumMember(Value = "dedicated")]
        Dedicated,
        [EnumMember(Value = "shared")]
        Shared,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
