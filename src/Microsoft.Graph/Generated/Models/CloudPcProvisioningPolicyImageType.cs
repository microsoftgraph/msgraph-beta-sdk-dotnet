using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcProvisioningPolicyImageType {
        [EnumMember(Value = "gallery")]
        Gallery,
        [EnumMember(Value = "custom")]
        Custom,
    }
}
