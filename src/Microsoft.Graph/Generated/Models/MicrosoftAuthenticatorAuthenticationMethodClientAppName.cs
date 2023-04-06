using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MicrosoftAuthenticatorAuthenticationMethodClientAppName {
        [EnumMember(Value = "microsoftAuthenticator")]
        MicrosoftAuthenticator,
        [EnumMember(Value = "outlookMobile")]
        OutlookMobile,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
