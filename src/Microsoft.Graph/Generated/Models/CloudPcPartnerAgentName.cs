using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcPartnerAgentName {
        [EnumMember(Value = "citrix")]
        Citrix,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
