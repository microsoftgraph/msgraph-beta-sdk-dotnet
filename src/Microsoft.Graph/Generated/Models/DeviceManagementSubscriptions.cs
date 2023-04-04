using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Tenant mobile device management subscriptions.</summary>
    public enum DeviceManagementSubscriptions {
        /// <summary>None</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Microsoft Intune Subscription</summary>
        [EnumMember(Value = "intune")]
        Intune,
        /// <summary>Office365 Subscription</summary>
        [EnumMember(Value = "office365")]
        Office365,
        /// <summary>Microsoft Intune Premium Subscription</summary>
        [EnumMember(Value = "intunePremium")]
        IntunePremium,
        /// <summary>Microsoft Intune for Education Subscription</summary>
        [EnumMember(Value = "intune_EDU")]
        Intune_EDU,
        /// <summary>Microsoft Intune for Small Businesses Subscription</summary>
        [EnumMember(Value = "intune_SMB")]
        Intune_SMB,
    }
}
