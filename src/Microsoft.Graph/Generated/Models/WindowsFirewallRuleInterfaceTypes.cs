using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Flags representing firewall rule interface types.</summary>
    public enum WindowsFirewallRuleInterfaceTypes {
        /// <summary>No flags set.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>The Remote Access interface type.</summary>
        [EnumMember(Value = "remoteAccess")]
        RemoteAccess,
        /// <summary>The Wireless interface type.</summary>
        [EnumMember(Value = "wireless")]
        Wireless,
        /// <summary>The LAN interface type.</summary>
        [EnumMember(Value = "lan")]
        Lan,
    }
}
