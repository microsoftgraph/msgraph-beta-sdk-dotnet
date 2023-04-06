using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Bind status of the tenant with the Google EMM API</summary>
    public enum AndroidManagedStoreAccountBindStatus {
        [EnumMember(Value = "notBound")]
        NotBound,
        [EnumMember(Value = "bound")]
        Bound,
        [EnumMember(Value = "boundAndValidated")]
        BoundAndValidated,
        [EnumMember(Value = "unbinding")]
        Unbinding,
    }
}
