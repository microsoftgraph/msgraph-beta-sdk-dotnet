// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum AwsSecurityToolWebServices
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "macie")]
        #pragma warning disable CS1591
        Macie = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "wafShield")]
        #pragma warning disable CS1591
        WafShield = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "cloudTrail")]
        #pragma warning disable CS1591
        CloudTrail = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "inspector")]
        #pragma warning disable CS1591
        Inspector = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "securityHub")]
        #pragma warning disable CS1591
        SecurityHub = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "detective")]
        #pragma warning disable CS1591
        Detective = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "guardDuty")]
        #pragma warning disable CS1591
        GuardDuty = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 128,
        #pragma warning restore CS1591
    }
}
