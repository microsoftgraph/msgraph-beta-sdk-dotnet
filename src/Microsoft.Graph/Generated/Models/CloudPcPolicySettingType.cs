using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcPolicySettingType {
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "singleSignOn")]
        SingleSignOn,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
