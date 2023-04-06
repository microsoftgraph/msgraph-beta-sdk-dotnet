using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrintColorMode {
        [EnumMember(Value = "blackAndWhite")]
        BlackAndWhite,
        [EnumMember(Value = "grayscale")]
        Grayscale,
        [EnumMember(Value = "color")]
        Color,
        [EnumMember(Value = "auto")]
        Auto,
    }
}
