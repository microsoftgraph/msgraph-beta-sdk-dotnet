using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum LanguageProficiencyLevel {
        [EnumMember(Value = "elementary")]
        Elementary,
        [EnumMember(Value = "conversational")]
        Conversational,
        [EnumMember(Value = "limitedWorking")]
        LimitedWorking,
        [EnumMember(Value = "professionalWorking")]
        ProfessionalWorking,
        [EnumMember(Value = "fullProfessional")]
        FullProfessional,
        [EnumMember(Value = "nativeOrBilingual")]
        NativeOrBilingual,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
