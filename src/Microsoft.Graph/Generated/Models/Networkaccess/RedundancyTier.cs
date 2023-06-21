using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public enum RedundancyTier {
        [EnumMember(Value = "noRedundancy")]
        NoRedundancy,
        [EnumMember(Value = "zoneRedundancy")]
        ZoneRedundancy,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
