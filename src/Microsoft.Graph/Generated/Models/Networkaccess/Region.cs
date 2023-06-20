using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public enum Region {
        [EnumMember(Value = "eastUS")]
        EastUS,
        [EnumMember(Value = "eastUS2")]
        EastUS2,
        [EnumMember(Value = "westUS")]
        WestUS,
        [EnumMember(Value = "westUS2")]
        WestUS2,
        [EnumMember(Value = "westUS3")]
        WestUS3,
        [EnumMember(Value = "centralUS")]
        CentralUS,
        [EnumMember(Value = "northCentralUS")]
        NorthCentralUS,
        [EnumMember(Value = "southCentralUS")]
        SouthCentralUS,
        [EnumMember(Value = "northEurope")]
        NorthEurope,
        [EnumMember(Value = "westEurope")]
        WestEurope,
        [EnumMember(Value = "franceCentral")]
        FranceCentral,
        [EnumMember(Value = "germanyWestCentral")]
        GermanyWestCentral,
        [EnumMember(Value = "switzerlandNorth")]
        SwitzerlandNorth,
        [EnumMember(Value = "ukSouth")]
        UkSouth,
        [EnumMember(Value = "canadaEast")]
        CanadaEast,
        [EnumMember(Value = "canadaCentral")]
        CanadaCentral,
        [EnumMember(Value = "southAfricaWest")]
        SouthAfricaWest,
        [EnumMember(Value = "southAfricaNorth")]
        SouthAfricaNorth,
        [EnumMember(Value = "uaeNorth")]
        UaeNorth,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
