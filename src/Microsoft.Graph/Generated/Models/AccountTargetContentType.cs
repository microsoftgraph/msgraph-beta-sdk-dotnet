using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AccountTargetContentType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "includeAll")]
        IncludeAll,
        [EnumMember(Value = "addressBook")]
        AddressBook,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
