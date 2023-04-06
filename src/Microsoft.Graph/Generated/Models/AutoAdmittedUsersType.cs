using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AutoAdmittedUsersType {
        [EnumMember(Value = "everyoneInCompany")]
        EveryoneInCompany,
        [EnumMember(Value = "everyone")]
        Everyone,
    }
}
