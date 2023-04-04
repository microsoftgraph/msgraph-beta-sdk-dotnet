using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Flags representing which network profile types apply to a firewall rule.</summary>
    public enum WindowsFirewallRuleNetworkProfileTypes {
        /// <summary>No flags set.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>The profile for networks that are connected to domains.</summary>
        [EnumMember(Value = "domain")]
        Domain,
        /// <summary>The profile for private networks.</summary>
        [EnumMember(Value = "private")]
        Private,
        /// <summary>The profile for public networks.</summary>
        [EnumMember(Value = "public")]
        Public,
    }
}
