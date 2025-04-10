// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Required AAD Trust Type</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementConfigurationAzureAdTrustType
    {
        /// <summary>No AAD Trust Type specified</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>AAD Joined Trust Type</summary>
        [EnumMember(Value = "azureAdJoined")]
        AzureAdJoined,
        /// <summary>AddWorkAccount</summary>
        [EnumMember(Value = "addWorkAccount")]
        AddWorkAccount,
        /// <summary>MDM only</summary>
        [EnumMember(Value = "mdmOnly")]
        MdmOnly,
    }
}
