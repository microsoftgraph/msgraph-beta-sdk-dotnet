using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AppKeyCredentialRestrictionType {
        [EnumMember(Value = "asymmetricKeyLifetime")]
        AsymmetricKeyLifetime,
        [EnumMember(Value = "trustedCertificateAuthority")]
        TrustedCertificateAuthority,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
