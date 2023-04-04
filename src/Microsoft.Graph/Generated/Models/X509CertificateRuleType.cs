using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum X509CertificateRuleType {
        [EnumMember(Value = "issuerSubject")]
        IssuerSubject,
        [EnumMember(Value = "policyOID")]
        PolicyOID,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
