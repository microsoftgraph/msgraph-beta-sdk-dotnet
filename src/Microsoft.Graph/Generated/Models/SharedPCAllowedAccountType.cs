using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of accounts that are allowed to share the PC.</summary>
    public enum SharedPCAllowedAccountType {
        /// <summary>Not configured. Default value.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Only guest accounts.</summary>
        [EnumMember(Value = "guest")]
        Guest,
        /// <summary>Only domain-joined accounts.</summary>
        [EnumMember(Value = "domain")]
        Domain,
    }
}
