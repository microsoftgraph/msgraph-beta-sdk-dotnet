using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DecisionItemPrincipalResourceMembershipType {
        [EnumMember(Value = "direct")]
        Direct,
        [EnumMember(Value = "indirect")]
        Indirect,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
