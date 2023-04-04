using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SkillProficiencyLevel {
        [EnumMember(Value = "elementary")]
        Elementary,
        [EnumMember(Value = "limitedWorking")]
        LimitedWorking,
        [EnumMember(Value = "generalProfessional")]
        GeneralProfessional,
        [EnumMember(Value = "advancedProfessional")]
        AdvancedProfessional,
        [EnumMember(Value = "expert")]
        Expert,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
