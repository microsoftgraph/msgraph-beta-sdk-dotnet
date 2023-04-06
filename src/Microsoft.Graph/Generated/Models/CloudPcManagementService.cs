using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcManagementService {
        [EnumMember(Value = "windows365")]
        Windows365,
        [EnumMember(Value = "devBox")]
        DevBox,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "rpaBox")]
        RpaBox,
    }
}
