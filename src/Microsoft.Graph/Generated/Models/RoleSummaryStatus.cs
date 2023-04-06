using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RoleSummaryStatus {
        [EnumMember(Value = "ok")]
        Ok,
        [EnumMember(Value = "bad")]
        Bad,
    }
}
