using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TitleAreaLayoutType {
        [EnumMember(Value = "imageAndTitle")]
        ImageAndTitle,
        [EnumMember(Value = "plain")]
        Plain,
        [EnumMember(Value = "colorBlock")]
        ColorBlock,
        [EnumMember(Value = "overlap")]
        Overlap,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
