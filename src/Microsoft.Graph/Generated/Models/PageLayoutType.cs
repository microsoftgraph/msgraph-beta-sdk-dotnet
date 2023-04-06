using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PageLayoutType {
        [EnumMember(Value = "microsoftReserved")]
        MicrosoftReserved,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
