using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EncryptWith {
        [EnumMember(Value = "template")]
        Template,
        [EnumMember(Value = "userDefinedRights")]
        UserDefinedRights,
    }
}
