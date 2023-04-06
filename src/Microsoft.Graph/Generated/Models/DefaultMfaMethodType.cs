using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DefaultMfaMethodType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "mobilePhone")]
        MobilePhone,
        [EnumMember(Value = "alternateMobilePhone")]
        AlternateMobilePhone,
        [EnumMember(Value = "officePhone")]
        OfficePhone,
        [EnumMember(Value = "microsoftAuthenticatorPush")]
        MicrosoftAuthenticatorPush,
        [EnumMember(Value = "softwareOneTimePasscode")]
        SoftwareOneTimePasscode,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
