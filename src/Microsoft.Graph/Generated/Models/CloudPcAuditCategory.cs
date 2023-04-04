using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcAuditCategory {
        [EnumMember(Value = "cloudPC")]
        CloudPC,
        [EnumMember(Value = "other")]
        Other,
    }
}
