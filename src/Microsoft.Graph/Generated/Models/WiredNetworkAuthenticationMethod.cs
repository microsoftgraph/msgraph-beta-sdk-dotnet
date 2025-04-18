// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Wired Network authentication method.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WiredNetworkAuthenticationMethod
    {
        /// <summary>Use an identity certificate for authentication.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
