using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum LocationUniqueIdType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "locationStore")]
        LocationStore,
        [EnumMember(Value = "directory")]
        Directory,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "bing")]
        Bing,
    }
}
