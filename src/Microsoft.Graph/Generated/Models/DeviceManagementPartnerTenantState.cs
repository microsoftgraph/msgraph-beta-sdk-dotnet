// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Partner state of this tenant.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementPartnerTenantState
    {
        /// <summary>Partner state is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Partner is unavailable.</summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
        /// <summary>Partner is enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Partner connection is terminated.</summary>
        [EnumMember(Value = "terminated")]
        Terminated,
        /// <summary>Partner messages are rejected.</summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>Partner is unresponsive.</summary>
        [EnumMember(Value = "unresponsive")]
        Unresponsive,
    }
}
