using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamTemplateAudience {
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
