using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum FeatureType {
        [EnumMember(Value = "registration")]
        Registration,
        [EnumMember(Value = "reset")]
        Reset,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
