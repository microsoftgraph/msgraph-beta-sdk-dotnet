using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum IndicatorSource {
        [EnumMember(Value = "microsoftDefenderThreatIntelligence")]
        MicrosoftDefenderThreatIntelligence,
        [EnumMember(Value = "openSourceIntelligence")]
        OpenSourceIntelligence,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
