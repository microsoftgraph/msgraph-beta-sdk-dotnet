using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PagePromotionType {
        [EnumMember(Value = "microsoftReserved")]
        MicrosoftReserved,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "newsPost")]
        NewsPost,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
